using StdBE100;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IBasBS100;
using PRISDK100;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmRecibo : Form
    {
        #region variables

        private Guid IdCab { get; }
        private string _entidade;
        private double _cambio;
        private string _processo;
        private string _serie;
        private string _filial;
        private DateTime _data;
        private string _docOrig;
        private string Processo { get; }
        #endregion

        #region metodos

        /// <summary>
        ///     Vai a BD e indica qual o documento, valor total. Pergunta se quer pagar na totalidade ou parcialmente.
        ///     Se for total ele copia o valor e preenche nas linhas do documento (TRT_TDU_LinhasDocumento), se for
        ///     parcial ele vai pagar as linhas seleccionadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRecibo_Load(object sender, EventArgs e)
        {
            dgvLinhasRecibo.AutoGenerateColumns = false;
            if (IdCab.ToString() != "")
            {
                var sql = new StringBuilder();

                sql.Append("SELECT CONCAT(C.CDU_Documento, ' ', C.CDU_Numero, '/', C.CDU_Serie) As Documento,  ");
                sql.Append("A.CDU_Nome As 'Item', SUM(L.CDU_Total) As 'Credito', SUM(L.CDU_ValorRec) As 'Debito', ");
                sql.Append("C.CDU_Cliente, C.CDU_Cambio, C.CDU_Processo ");
                sql.Append("FROM TDU_TRT_CabecDocumentos C ");
                sql.Append("INNER JOIN TDU_TRT_LinhasDocumentos L ");
                sql.Append("ON C.CDU_Id = L.CDU_IdDoc ");
                sql.Append("INNER JOIN TDU_TRT_Items A ");
                sql.Append("ON L.CDU_Artigo = A.CDU_Codigo ");
                sql.Append($"WHERE C.CDU_Id = '{IdCab}' ");
                sql.Append("GROUP BY CDU_Processo, C.CDU_Nome, CDU_Documento, CDU_Numero, CDU_Serie, A.CDU_Nome, C.CDU_Cliente, C.CDU_Cambio, C.CDU_Processo ");

                var query = sql.ToString();

                var lstDocumento = PriEngine.Engine.Consulta(query);

                if (!lstDocumento.Vazia())
                {
                    double valorTotal = 0;
                    txtDocumento.Text = lstDocumento.Valor(0).ToString();
                    txtValorRec.Text = lstDocumento.Valor(3).ToString();

                    while (!lstDocumento.NoFim())
                    {
                        valorTotal += lstDocumento.Valor((2));
                        lstDocumento.Seguinte();
                    }

                    txtValorTot.Text = valorTotal.ToString(CultureInfo.InvariantCulture);

                    if (txtValorRec.Text == "") txtValorRec.Text = 0.ToString();
                }

                PopulaGrelhaLinhasRecibo();
            }
        }

        private void CriaLiquidacao(double total, string idLinha, Guid idCabec)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using var sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            using (var transaction = sqlCon.BeginTransaction())
            {
                var sqlCmdVRec = new SqlCommand("TDU_TRT_ValorRecLinhasDoc", sqlCon)
                {
                    Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                };
                sqlCmdVRec.Parameters.AddWithValue("@idLinha", idLinha);
                sqlCmdVRec.ExecuteNonQuery();

                var sqlCmdCriaLiq = new SqlCommand("TDU_TRT_CriaLiquidacao", sqlCon)
                {
                    Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                };
                sqlCmdCriaLiq.Parameters.AddWithValue("@idLinha", idLinha);
                sqlCmdCriaLiq.Parameters.AddWithValue("@idDoc", idCabec);
                sqlCmdCriaLiq.Parameters.AddWithValue("@total", total);
                sqlCmdCriaLiq.ExecuteNonQuery();
                
                transaction.Commit();
            }

            sqlCon.Close();
            
            
            PriEngine.Platform.Dialogos.MostraAviso("Liquidação criada com sucesso.");
        }

        private void CriaDocErp(Guid[] idLinhas)
        {
            string query = $"SELECT CDU_Cliente, CDU_Documento, CDU_Serie, CDU_Cambio, CDU_Processo FROM TDU_TRT_CabecDocumentos WHERE CDU_Id = '{IdCab}'";
            StdBELista lstDados = PriEngine.Engine.Consulta(query);
            int i = 0;
            int j = idLinhas.Length;
            string[] docs = new string[j];
            
            if (!lstDados.Vazia())
            {
                _entidade = lstDados.Valor(0);
                _docOrig = lstDados.Valor(1);
                _cambio = lstDados.Valor(3);
                _processo = lstDados.Valor(4);
                _filial = "000";
                _data = DateTime.Now.Date;
                _serie = DateTime.Now.Year.ToString();
            }
            
            foreach (var idLin in idLinhas)
            {
                if (idLin.ToString() != "00000000-0000-0000-0000-000000000000")
                {
                    MessageBox.Show(idLin.ToString());
                    var sql = new StringBuilder();
                    sql.Append("SELECT DISTINCT(I.CDU_DocPrimavera) ");
                    sql.Append("FROM TDU_TRT_Items I ");
                    sql.Append("INNER JOIN TDU_TRT_LinhasDocumentos L ON L.CDU_Artigo = I.CDU_Codigo "); 
                    sql.Append("INNER JOIN TDU_TRT_CabecDocumentos C ON C.CDU_Id = L.CDU_IdDoc ");
                    sql.Append($"WHERE L.CDU_Id = '{idLin.ToString()}' ");
                    string queryDocs = sql.ToString();
                    StdBELista lstDocs = PriEngine.Engine.Consulta(queryDocs);
                    docs[i] = lstDocs.Valor(0).ToString();
                    i += 1;    
                }
            }

            var distinctDocs = docs.Distinct().ToArray(); 
            CriaDocExplorer(distinctDocs, idLinhas);
        }

        private void CriaDocExplorer(string[] documentos, Guid[] idLinhas)
        {
            foreach (var doc in documentos)
            {
                List<Linha> Linhas = new List<Linha>();
                
                foreach (Guid idLin in idLinhas)
                {
                    MessageBox.Show(idLin.ToString());
                    string artigo = string.Empty;
                    double qtd = 1;
                    double precUnit = 0;
                    double precIva = 0;
                    
                    var sql = new StringBuilder();
                    sql.Append("SELECT CDU_Artigo, CDU_Quantidade, CDU_PrecIVA, CDU_PrecUnit ");
                    sql.Append("FROM TDU_TRT_LinhasDocumentos ");
                    sql.Append($"WHERE CDU_Id = '{idLin.ToString()}' ");
                    string queryDocs = sql.ToString();
                    StdBELista lstDocs = PriEngine.Engine.Consulta(queryDocs);

                    Linha linha = new Linha(artigo, qtd, precUnit, precIva);
                    linha._artigo = lstDocs.Valor(0).ToString();
                    linha._qtd = Convert.ToDouble(lstDocs.Valor(1));
                    linha._precIva = Convert.ToDouble(lstDocs.Valor(2));
                    linha._precUnit = Convert.ToDouble(lstDocs.Valor(3));
                    Linhas.Add(linha);
                }

                foreach (var lin in Linhas)
                {
                    MessageBox.Show(lin._artigo);
                }
                
                //for (int i = 0; i < numLinhas; i++) 
                //{
                //    Linhas.Add(new Linha((string)sqlResultado[0], (decimal)sqlResultado["L.CDU_Quantidade"], 
                //        (double)sqlResultado["L.CDU_PrecUnit"], (double)sqlResultado["L.CDU_PrecIVA"]));
                //}
                    
                //sqlResultado.Dispose();
                

                //Integra Primavera
                IntegraPrimavera docErp = new IntegraPrimavera();
                docErp.CriaDocumentoErpTrt(doc, _entidade, _data, _cambio, _serie, _processo, Linhas);
            }
        }

        #endregion

        #region grelha

        /// <summary>
        ///     Popula a grelha baseada no Id passado para a FrmRecibo, vai ler as linhas de artigos.
        /// </summary>
        private void PopulaGrelhaLinhasRecibo()
        {
            if (IdCab.ToString() != "")
                try
                {
                    var connectionString = ConfigurationManager
                        .ConnectionStrings["ConnectionString"].ConnectionString;

                    using var sqlCon = new SqlConnection(connectionString);
                    var sql = new StringBuilder();

                    sql.Append("SELECT 0, A.CDU_Nome As 'Item', SUM(L.CDU_Total) As 'ValorTotal', L.CDU_id As 'IdLinha' ");
                    sql.Append("FROM TDU_TRT_CabecDocumentos C ");
                    sql.Append("INNER JOIN TDU_TRT_LinhasDocumentos L ");
                    sql.Append("ON C.CDU_Id = L.CDU_IdDoc ");
                    sql.Append("INNER JOIN TDU_TRT_Items A ");
                    sql.Append("ON L.CDU_Artigo = A.CDU_Codigo ");
                    sql.Append($"WHERE C.CDU_Id = '{IdCab}' ");
                    sql.Append("AND L.CDU_ValorRec is null ");
                    sql.Append("GROUP BY A.CDU_Nome, L.CDU_Id ");

                    var query = sql.ToString();
                    sqlCon.Open();
                    var sqlDa = new SqlDataAdapter(query, sqlCon);
                    var dataTable = new DataTable();
                    dataTable.Columns.Add("Sel.", typeof(CheckBox));
                    dataTable.Columns.Add("Item", typeof(string));
                    dataTable.Columns.Add("ValorTotal", typeof(string));
                    dataTable.Columns.Add("IdLinha", typeof(string));
                    dataTable.AcceptChanges();
                    sqlDa.Fill(dataTable);

                    foreach (DataRow dr in dataTable.Rows) dgvLinhasRecibo.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

                    dgvLinhasRecibo.Columns[0].Width = 50;
                    dgvLinhasRecibo.Columns[1].Width = 300;
                    dgvLinhasRecibo.Columns[2].Width = 100;
                    dgvLinhasRecibo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
                    dgvLinhasRecibo.DefaultCellStyle.Font = new Font("Arial", 10);
                    sqlCon.Close();
                }
                catch (Exception)
                {
                    //
                }
        }

        private void DgvLinhasRecibo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SomaValorRecebidoGrelha();
        }

        private void SomaValorRecebidoGrelha()
        {
            int linha;
            double soma = 0;

            for (linha = 0; linha < (dgvLinhasRecibo.Rows.Count); linha++)
            {
                if (dgvLinhasRecibo.Rows[linha].Cells["Select"].Value is true)
                {
                    soma += double.Parse(dgvLinhasRecibo.Rows[linha].Cells["ValorTotal"].Value.ToString());
                }
                else
                {
                    soma += 0;
                }
            }

            txtValorRec.Text = soma.ToString(CultureInfo.InvariantCulture);
        }

        private void LimpaGrelhaLinhasRecibo()
        {
            var dt = (DataTable) dgvLinhasRecibo.DataSource;
            dt?.Clear();
        }

        #endregion

        #region form

        public FrmRecibo(Guid idCab, string processo)
        {
            IdCab = idCab;
            Processo = processo;
            InitializeComponent();
        }

        /// <summary>
        ///     Altera o valor do txtValorRec para um valor igual a do txtValorTot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChbTotal_CheckedChanged(object sender, EventArgs e)
        {
            txtValorRec.Text = chbTotal.Checked ? txtValorTot.Text : 0.ToString();
        }

        private void BtnSERFRMREQCria_Click(object sender, EventArgs e)
        {
            if (chbTotal.Checked)
            {
                if (IdCab.ToString() != "")
                {
                    try
                    {
                        int i = 0;
                        foreach (DataGridViewRow dgvr in dgvLinhasRecibo.Rows)
                        {
                            double total = Convert.ToDouble(dgvr.Cells[2].Value.ToString());
                            string idLinha = dgvr.Cells[3].Value.ToString();
                            CriaLiquidacao(total, idLinha, IdCab);
                            i += 1;
                        }

                        if (Convert.ToInt32(i) > 0)
                        {
                            //CriaDocErp();
                        }
                    }
                    catch (Exception ex)
                    {
                        PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar a Liquidação: {ex.Message}");
                    }

                    LimpaGrelhaLinhasRecibo();
                    PopulaGrelhaLinhasRecibo();
                }
            }
            else
            {
                if (IdCab.ToString() != "")
                {
                    try
                    {
                        int j = 0;
                        foreach (DataGridViewRow dgvr in dgvLinhasRecibo.Rows)
                        {
                            if (dgvr.Cells[0].Value.ToString() == "True")
                            {
                                j += 1;
                            }
                        }

                        Guid[] idLinhas = new Guid[j];
                        int i = 1;
                        foreach (DataGridViewRow dgvr in dgvLinhasRecibo.Rows)
                        {
                            if (dgvr.Cells[0].Value.ToString() == "True")
                            {

                                double total = Convert.ToDouble(dgvr.Cells[2].Value.ToString());
                                string idLinha = dgvr.Cells[3].Value.ToString();
                                MessageBox.Show(idLinha);
                                idLinhas[i] = new Guid(idLinha);
                                
                                CriaLiquidacao(total, idLinha, IdCab);
                                
                                i += 1;
                            }

                            if (i > 0)
                            {
                                CriaDocErp(idLinhas);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar a Liquidação: {ex.Message}");
                    }

                    LimpaGrelhaLinhasRecibo();
                    PopulaGrelhaLinhasRecibo();
                }
            }
        }

        #endregion
    }
}
