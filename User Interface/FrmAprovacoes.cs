using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StdBE100;
using TRTv10.Engine;

namespace TRTv10.User_Interface
{
    public partial class FrmAprovacoes : Form
    {
        #region form

        public FrmAprovacoes()
        {
            InitializeComponent();
        }

        public void Aprovacoes_Load(object sender, EventArgs e)
        {
            ActualizaAprovacoes();
        }

        private void dgvAprovacoes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //GravaDadosGrelhav2();
        }

        private void dgvAprovacoes_Click(object sender, DataGridViewCellEventArgs e)
        {
            GravaDadosGrelha();
        }
        #endregion

        #region metodos/funçoes

        private void ActualizaAprovacoes()
        {
            LimpaGrelhaApr();
            PopulaGrelhaAprovacoes();
        }

        private string NivelAutorizacao()
        {
            string nivelAuto = string.Empty;
            var connectionString = ConfigurationManager.ConnectionStrings[name: "ConnectionString"].ConnectionString;
            using var sqlCon = new SqlConnection(connectionString: connectionString);
            var sql = new StringBuilder();

            sqlCon.Open();
            string query = ("SELECT CDU_Autorizacao FROM [PRIEMPRE].[dbo].[Utilizadores] " +
                            $"WHERE [PRIEMPRE].[dbo].[Utilizadores].[Codigo] = '{PriEngine.Engine.Contexto.UtilizadorActual}' ");
            StdBELista lstNivelAuto = PriEngine.Engine.Consulta(query);
            
            if (!lstNivelAuto.Vazia())
            {
                nivelAuto = lstNivelAuto.Valor(0).ToString();
            }
            
            sqlCon.Close();
            return nivelAuto;
        }
        
        #endregion

        #region grelha

        private void LimpaGrelhaApr()
        {
            var dt = (DataTable) dgvAprovacoes.DataSource;
            if (dgvAprovacoes.RowCount > 1)
            {
                dgvAprovacoes.Rows.Clear();
            }
                
            if(dt != null)
                dt.Clear();
        }

        private void PopulaGrelhaAprovacoes()
        {
            LimpaGrelhaApr();
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using var sqlCon = new SqlConnection(connectionString);
            var sql = new StringBuilder();

            sql.Append("SELECT CDU_Documento, CDU_Numero, CDU_Serie, ");
            sql.Append("CDU_DataDocumento As 'Data', CDU_Processo As 'Processo', CDU_Cliente As 'Cliente', CDU_Nome As 'Nome',  ");
            sql.Append("CDU_Aprovacao1 As 'Apr Tesouraria', CDU_Aprovacao2 As 'Apr Operacoes', CDU_Aprovacao3 As 'Apr Direcçao', CDU_Aprovacao4 As 'Pgto Tesouraria' ");
            sql.Append("FROM TDU_TRT_Aprovacoes ");
            sql.Append("WHERE CDU_Aprovacao4 = 0 ");

            var query = sql.ToString();
            sqlCon.Open();
            var sqlDa = new SqlDataAdapter(query, sqlCon);
            var dataTable = new DataTable();
            dataTable.Columns.Add("Doc", typeof(string));
            dataTable.Columns.Add("Nº", typeof(int));
            dataTable.Columns.Add("Serie", typeof(string));
            dataTable.Columns.Add("Data", typeof(string));
            dataTable.Columns.Add("Processo", typeof(string));
            dataTable.Columns.Add("Cliente", typeof(string));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("Apr Tesouraria", typeof(bool));
            dataTable.Columns.Add("Apr Operacões", typeof(bool));
            dataTable.Columns.Add("Apr Direcção", typeof(bool));
            dataTable.Columns.Add("Pgt Tesouraria", typeof(bool));
            dataTable.AcceptChanges();
            sqlDa.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                if (dr[11].ToString() != "")
                {
                    dgvAprovacoes.Rows.Add(dr[11], dr[12], dr[13], 
                        dr[3], dr[4], dr[5], dr[6], 
                        dr[7], dr[14], dr[15], dr[16]);
                }
            }
            
            dgvAprovacoes.Columns[0].Width = 75;
            dgvAprovacoes.Columns[1].Width = 75;
            dgvAprovacoes.Columns[2].Width = 75;
            dgvAprovacoes.Columns[3].Width = 100;
            dgvAprovacoes.Columns[4].Width = 100;
            dgvAprovacoes.Columns[5].Width = 100;
            dgvAprovacoes.Columns[6].Width = 350;
            dgvAprovacoes.Columns[7].Width = 100;
            dgvAprovacoes.Columns[8].Width = 100;
            dgvAprovacoes.Columns[9].Width = 100;
            dgvAprovacoes.Columns[10].Width = 100;
            dgvAprovacoes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            dgvAprovacoes.DefaultCellStyle.Font = new Font("Arial", 10);
            sqlCon.Close();
        }

        private void GravaDadosGrelha()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings[name: "ConnectionString"].ConnectionString;
                string nivelAuto = NivelAutorizacao();
                
                if (dgvAprovacoes.CurrentRow == null) return;
                using var sqlCon = new SqlConnection(connectionString: connectionString);
                sqlCon.Open();
                    
                var dgvRow = dgvAprovacoes.CurrentRow;
                if (nivelAuto == "N1")
                {
                    var sqlCmd = new SqlCommand(cmdText: "TDU_TRT_GrelhaAPRN1_Edit", connection: sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    sqlCmd.Parameters.AddWithValue(parameterName: "@Processo",
                        value: dgvRow.Cells[columnName: "Processo"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Processo"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Doc",
                            value: dgvRow.Cells[columnName: "Doc"].Value == DBNull.Value
                                ? ""
                                : dgvRow.Cells[columnName: "Doc"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@NumDoc",
                            value: Convert.ToDouble(
                                value: dgvRow.Cells[columnName: "Num"].Value == DBNull.Value
                                    ? 0
                                    : dgvRow.Cells[columnName: "Num"].Value));
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Serie",
                            value: dgvRow.Cells[columnName: "Serie"].Value == DBNull.Value
                                ? ""
                                : dgvRow.Cells[columnName: "Serie"].Value.ToString());

                    if (dgvRow.Cells[columnName: "AprTesouraria"].Selected)
                    {
                        var aprovacao = dgvRow.Cells[columnName: "AprTesouraria"].Value;
                        int bit = 0;

                        if (aprovacao != null && aprovacao.ToString() == "False")
                        {
                            bit = 1;
                        }

                        if (aprovacao != null && aprovacao.ToString() == "True")
                        {
                            bit = 0;
                        }

                        sqlCmd.Parameters.AddWithValue(parameterName: "@AprTes",
                            value: bit);
                    }
                    else
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Não tem permissões para alterar");
                    }
                    sqlCmd.ExecuteNonQuery();
                    PopulaGrelhaAprovacoes();
                }

                if (nivelAuto == "N2")
                {
                    var sqlCmd = new SqlCommand(cmdText: "TDU_TRT_GrelhaAPRN2_Edit", connection: sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    sqlCmd.Parameters.AddWithValue(parameterName: "@Processo",
                        value: dgvRow.Cells[columnName: "Processo"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Processo"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Doc",
                        value: dgvRow.Cells[columnName: "Doc"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Doc"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@NumDoc",
                        value: Convert.ToDouble(
                            value: dgvRow.Cells[columnName: "Num"].Value == DBNull.Value
                                ? 0
                                : dgvRow.Cells[columnName: "Num"].Value));
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Serie",
                        value: dgvRow.Cells[columnName: "Serie"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Serie"].Value.ToString());

                    if (dgvRow.Cells[columnName: "AprOperacoes"].Selected)
                    {
                        var aprovacao = dgvRow.Cells[columnName: "AprOperacoes"].Value.ToString();
                        int bit = 0;

                        if (aprovacao.ToString() == "False")
                        {
                            bit = 1;
                        }
                    
                        if (aprovacao.ToString() == "True")
                        {
                            bit = 0;
                        }

                        sqlCmd.Parameters.AddWithValue(parameterName: "@AprOp",
                            value: bit);
                    }
                    else
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Não tem permissões para alterar");
                    }
                    sqlCmd.ExecuteNonQuery();
                    PopulaGrelhaAprovacoes();
                }

                if (nivelAuto == "N3")
                {
                    var sqlCmd = new SqlCommand(cmdText: "TDU_TRT_GrelhaAPRN3_Edit", connection: sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    sqlCmd.Parameters.AddWithValue(parameterName: "@Processo",
                        value: dgvRow.Cells[columnName: "Processo"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Processo"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Doc",
                        value: dgvRow.Cells[columnName: "Doc"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Doc"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@NumDoc",
                        value: Convert.ToDouble(
                            value: dgvRow.Cells[columnName: "Num"].Value == DBNull.Value
                                ? 0
                                : dgvRow.Cells[columnName: "Num"].Value));
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Serie",
                        value: dgvRow.Cells[columnName: "Serie"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Serie"].Value.ToString());

                    if (dgvRow.Cells[columnName: "AprTesouraria"].Selected)
                    {
                        var aprovacaoTes = dgvRow.Cells[columnName: "AprTesouraria"].Value.ToString();
                        int bit = 0;

                        if (aprovacaoTes.ToString() == "False")
                        {
                            bit = 1;
                        }

                        if (aprovacaoTes.ToString() == "True")
                        {
                            bit = 0;
                        }

                        sqlCmd.Parameters.AddWithValue(parameterName: "@AprTes",
                            value: bit);

                        sqlCmd.ExecuteNonQuery();
                        PopulaGrelhaAprovacoes();
                    }

                    if (dgvRow.Cells[columnName: "AprOperacoes"].Selected)
                    {
                        var aprovacaoOp = dgvRow.Cells[columnName: "AprOperacoes"].Value.ToString();
                        int bit = 0;

                        if (aprovacaoOp.ToString() == "False")
                        {
                            bit = 1;
                        }

                        if (aprovacaoOp.ToString() == "True")
                        {
                            bit = 0;
                        }

                        sqlCmd.Parameters.AddWithValue(parameterName: "@AprOp",
                            value: bit);

                        sqlCmd.ExecuteNonQuery();
                        PopulaGrelhaAprovacoes();
                    }

                    if (dgvRow.Cells[columnName: "AprDireccao"].Selected)
                    {
                        var aprovacaoDir = dgvRow.Cells[columnName: "AprDireccao"].Value.ToString();
                        int bit = 0;
                        if (aprovacaoDir.ToString() == "False")
                        {
                            bit = 1;
                        }

                        if (aprovacaoDir.ToString() == "True")
                        {
                            bit = 0;
                        }

                        sqlCmd.Parameters.AddWithValue(parameterName: "@AprDir",
                            value: bit);

                        sqlCmd.ExecuteNonQuery();
                        PopulaGrelhaAprovacoes();
                    }

                    if (dgvRow.Cells[columnName: "AprPagamento"].Selected)
                    {
                        var aprovacaoPgt = dgvRow.Cells[columnName: "AprPagamento"].Value.ToString();
                        int bit = 0;
                        if (aprovacaoPgt.ToString() == "False")
                        {
                            bit = 1;
                        }

                        if (aprovacaoPgt.ToString() == "True")
                        {
                            bit = 0;
                        }

                        sqlCmd.Parameters.AddWithValue(parameterName: "@AprPgt",
                            value: bit);

                        sqlCmd.ExecuteNonQuery();
                        PopulaGrelhaAprovacoes();
                    }
                }
                
                if (nivelAuto == "N4")
                {
                    var sqlCmd = new SqlCommand(cmdText: "TDU_TRT_GrelhaAPRN4_Edit", connection: sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    sqlCmd.Parameters.AddWithValue(parameterName: "@Processo",
                        value: dgvRow.Cells[columnName: "Processo"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Processo"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Doc",
                        value: dgvRow.Cells[columnName: "Doc"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Doc"].Value.ToString());
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@NumDoc",
                        value: Convert.ToDouble(
                            value: dgvRow.Cells[columnName: "Num"].Value == DBNull.Value
                                ? 0
                                : dgvRow.Cells[columnName: "Num"].Value));
                    
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Serie",
                        value: dgvRow.Cells[columnName: "Serie"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "Serie"].Value.ToString());

                    if (dgvRow.Cells[columnName: "AprPagamento"].Selected)
                    {
                        var aprovacao = dgvRow.Cells[columnName: "AprPagamento"].Value.ToString();
                        int bit = 0;

                        if (aprovacao.ToString() == "False")
                        {
                            bit = 1;
                        }
                    
                        if (aprovacao.ToString() == "True")
                        {
                            bit = 0;
                        }

                        sqlCmd.Parameters.AddWithValue(parameterName: "@AprPgt",
                            value: bit);

                    }
                    else
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Não tem permissões para alterar");
                    }
                    sqlCmd.ExecuteNonQuery();
                    PopulaGrelhaAprovacoes();
                }
                
                sqlCon.Close();
            }
            catch
            {
                //"Evita erro ao inicializar";
            }
        }


        #endregion
    }
}
