using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmProcesso : Form
    {
        #region metodos

        public void ActualizaDadosClientes()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Cliente ");
            sql.Append("FROM [dbo].[Clientes] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbPROCliente.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbPROCliente.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }
        public void ActualizaDadosProcesso()
        {
            try
            {
                if (cbPROCliente.Text == "")
                {
                    var query = $"SELECT CDU_Codigo FROM [dbo].[TDU_TRT_Processo]";

                    var lstPesquisa = PriEngine.Engine.Consulta(query);

                    if (!lstPesquisa.Vazia())
                    {
                        cbPRONumProcesso.Items.Clear();

                        while (!lstPesquisa.NoFim())
                        {
                            cbPRONumProcesso.Items.Add(item: lstPesquisa.Valor(0));
                            lstPesquisa.Seguinte();
                        }
                    }
                }
                else
                {
                    cbPRONumProcesso.Items.Clear();
                    var query = $"SELECT CDU_Codigo FROM [dbo].[TDU_TRT_Processo] WHERE CDU_Cliente = '{cbPROCliente.Text}'";
                    var lstPesquisa = PriEngine.Engine.Consulta(query);

                    if (!lstPesquisa.Vazia())
                    {
                        while (!lstPesquisa.NoFim())
                        {
                            cbPRONumProcesso.Items.Add(item: lstPesquisa.Valor(0));
                            lstPesquisa.Seguinte();
                        }
                    }
                }
            }
            catch
            {
                //
            }
        }

        #endregion

        #region variaveis

        private Guid IdOrig { get; set; }

        private Guid IdLin { get; set; }

        private Guid IdCab { get; set; }

        #endregion

        #region form

        /// <summary>
        /// Form load
        /// </summary>
        public FrmProcesso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Caso seja selecionado um cliente ele actualiza a lista de processos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbPROCliente_Leave(object sender, EventArgs e)
        {
            ActualizaDadosProcesso();
        }

        /// <summary>
        ///     Carrega o Processo, actualmente vazio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Processo_Load(object sender, EventArgs e)
        {
            ActualizaDadosProcesso();
        }

        private void dgvDocumentosRI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        ///     Consoante o processo escolhido ele limpa a grelha e popula com os dados desse processo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbPRONumProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LimpaGrelhaRi();
                LimpaGrelhaVnd();
                LimpaGrelhaVndLin();
                PopulaGrelhaRi(cbPRONumProcesso.Text);
                PopulaGrelhaVnd(cbPRONumProcesso.Text);
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar os menus {ex.Message}");
            }
        }

        #endregion

        #region grelha

        /// <summary>
        ///     Limpa a grelha Requisiçao Interna
        /// </summary>
        private void LimpaGrelhaRi()
        {
            var dt = (DataTable) dgvDocumentosRI.DataSource;
            dt?.Clear();
        }

        /// <summary>
        ///     Limpa a grelha das vendas (meio)
        /// </summary>
        private void LimpaGrelhaVnd()
        {
            var dt = (DataTable) dgvDocumentosVND.DataSource;
            dt?.Clear();
        }

        /// <summary>
        ///     Limpa a grelha das linhas
        /// </summary>
        private void LimpaGrelhaVndLin()
        {
            var dt = (DataTable) dgvDocumentoVNDLin.DataSource;
            dt?.Clear();
        }

        /// <summary>
        ///     Mediante o processo escolhido carrega todas as RI
        /// </summary>
        /// <param name="processo"></param>
        private void PopulaGrelhaRi(string processo)
        {
            if (processo != "")
            {
                var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using var sqlCon = new SqlConnection(connectionString);
                var sql = new StringBuilder();

                if (cbPRONumProcesso.Text == "") return;
                sql.Append("SELECT CDU_Processo As 'Processo', C.CDU_Nome As 'Cliente', ");
                sql.Append("CONCAT(C.CDU_Documento, ' ', C.CDU_Numero, '/', C.CDU_Serie) As Documento,  ");
                sql.Append("A.CDU_Nome As 'Item', SUM(L.CDU_Total) As 'Credito', SUM(L.CDU_ValorRec) As 'Debito' ");
                sql.Append("FROM TDU_TRT_CabecDocumentos C ");
                sql.Append("INNER JOIN TDU_TRT_LinhasDocumentos L ");
                sql.Append("ON C.CDU_Id = L.CDU_IdDoc ");
                sql.Append("INNER JOIN TDU_TRT_Items A ");
                sql.Append("ON L.CDU_Artigo = A.CDU_Codigo ");
                sql.Append($"WHERE CDU_Processo = '{processo}' ");
                sql.Append("AND CDU_Documento = 'RI' ");
                sql.Append("GROUP BY CDU_Processo, C.CDU_Nome, CDU_Documento, CDU_Numero, CDU_Serie, A.CDU_Nome ");

                var query = sql.ToString();
                sqlCon.Open();
                var sqlDa = new SqlDataAdapter(query, sqlCon);
                var dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                dgvDocumentosRI.DataSource = dataTable;
                dgvDocumentosRI.Columns[0].Width = 90;
                dgvDocumentosRI.Columns[1].Width = 300;
                dgvDocumentosRI.Columns[2].Width = 125;
                dgvDocumentosRI.Columns[3].Width = 200;
                dgvDocumentosRI.Columns[4].Width = 100;
                dgvDocumentosRI.Columns[5].Width = 100;
                dgvDocumentosRI.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
                dgvDocumentosRI.DefaultCellStyle.Font = new Font("Arial", 10);
                sqlCon.Close();
            }
        }

        /// <summary>
        ///     Mediante o processo escolhido carrega todos os docs de Vendas excepto RI
        /// </summary>
        /// <param name="processo"></param>
        private void PopulaGrelhaVnd(string processo)
        {
            if (processo != "")
            {
                var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using var sqlCon = new SqlConnection(connectionString);
                var sql = new StringBuilder();

                if (cbPRONumProcesso.Text == "") return;
                sql.Append("SELECT ");
                sql.Append("CASE WHEN C.CDU_Processo LIKE 'COT%' THEN RIGHT(C.CDU_Processo, LEN(C.CDU_Processo) - 3) ELSE C.CDU_Processo END AS 'Processo', ");
                sql.Append("C.CDU_Nome As 'Cliente', CDU_Documento As 'Documento', CDU_Numero As 'Numero', CDU_Serie As 'Serie', ");
                sql.Append("SUM(L.CDU_Total) As 'Total', SUM(L.CDU_ValorRec) As 'Valor Recebido' ");
                sql.Append("FROM TDU_TRT_CabecDocumentos C ");
                sql.Append("INNER JOIN TDU_TRT_LinhasDocumentos L ");
                sql.Append("ON C.CDU_Id = L.CDU_IdDoc ");
                sql.Append($"WHERE CDU_Processo = {processo} ");
                sql.Append("AND CDU_Documento <> 'RI' ");
                sql.Append("GROUP BY CDU_Processo, CDU_Nome, CDU_Documento, CDU_Numero, CDU_Serie");

                var query = sql.ToString();
                sqlCon.Open();
                var sqlDa = new SqlDataAdapter(query, sqlCon);
                var dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                dgvDocumentosVND.DataSource = dataTable;
                dgvDocumentosVND.Columns[0].Width = 100;
                dgvDocumentosVND.Columns[1].Width = 300;
                dgvDocumentosVND.Columns[2].Width = 100;
                dgvDocumentosVND.Columns[3].Width = 75;
                dgvDocumentosVND.Columns[4].Width = 50;
                dgvDocumentosVND.Columns[5].Width = 100;
                //dgvDocumentosVND.Columns[6].Width = 100;
                dgvDocumentosVND.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
                dgvDocumentosVND.DefaultCellStyle.Font = new Font("Arial", 10);
                sqlCon.Close();
            }
        }

        /// <summary>
        ///     Vai permitir que ao clicarem com o lado direito ele pergunte se querem criar um Recibo
        ///     caso sim, ele abre o form do recibo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDocumentosVND_CellContextMenuStripNeeded(object sender,
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            try
            {
                var dgv = (DataGridView) sender;

                if (e.RowIndex == -1 || e.ColumnIndex == -1)
                    return;

                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    var documento = (string) row.Cells["Documento"].Value;
                    var serie = (string) row.Cells["Serie"].Value;
                    var numDocumento = (int) row.Cells["Numero"].Value;

                    var query = $"SELECT CDU_Id FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '{documento}' " +
                                $"AND CDU_Serie = '{serie}' AND CDU_Numero = '{numDocumento}'  ";
                    var lstQ = PriEngine.Engine.Consulta(query);

                    if (lstQ.NumLinhas() == 0) return;
                    IdCab = lstQ.Valor(0);
                }

                e.ContextMenuStrip = cmsREC;
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar as linhas {ex.Message}");
            }
        }

        /// <summary>
        ///     Conforme um documento e escolhido na Grid dos Documentos, ele vai carregar
        ///     todas as linhas pertencentes a este no quadro inferior, com o intuito
        ///     de podermos criar as RI atraves dessas linhas/selecções
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDocumentosVND_Click(object sender, EventArgs e)
        {
            try
            {
                var dgv = (DataGridView) sender;

                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    var documento = (string) row.Cells["Documento"].Value;
                    var serie = (string) row.Cells["Serie"].Value;
                    var numDocumento = (int) row.Cells["Numero"].Value;
                    var queryId =
                        $"SELECT CDU_Id FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '{documento}' " +
                        $"AND CDU_Numero = '{numDocumento}' AND CDU_Serie = '{serie}'";
                    var listaId = PriEngine.Engine.Consulta(queryId);
                    if (listaId.Vazia()) return;
                    IdOrig = listaId.Valor(0);

                    var connectionString = ConfigurationManager
                        .ConnectionStrings["ConnectionString"].ConnectionString;

                    using var sqlCon = new SqlConnection(connectionString);
                    var sql = new StringBuilder();

                    if (cbPRONumProcesso.Text == "") return;
                    sql.Append(
                        "SELECT CDU_NumLinha AS 'Linha',  A.CDU_Nome As 'Artigo', CDU_Quantidade As 'Qtd', ");
                    sql.Append(
                        "CDU_PrecUnit As 'Valor Unitario', CDU_PrecIVA As 'Valor IVA', CDU_Total As 'Total', " +
                        "CDU_ValorRec As 'Valor Recebido' ");
                    sql.Append("FROM TDU_TRT_LinhasDocumentos L ");
                    sql.Append("INNER JOIN TDU_TRT_Items A ON A.CDU_Codigo = L.CDU_Artigo ");
                    sql.Append($"WHERE L.CDU_IdDoc = '{IdOrig}'");

                    var query = sql.ToString();
                    sqlCon.Open();
                    var sqlDa = new SqlDataAdapter(query, sqlCon);
                    var dataTable = new DataTable();
                    sqlDa.Fill(dataTable);
                    dgvDocumentoVNDLin.DataSource = dataTable;
                    dgvDocumentoVNDLin.Columns[0].Width = 50;
                    dgvDocumentoVNDLin.Columns[1].Width = 300;
                    dgvDocumentoVNDLin.Columns[2].Width = 50;
                    dgvDocumentoVNDLin.Columns[3].Width = 100;
                    dgvDocumentoVNDLin.Columns[4].Width = 100;
                    dgvDocumentoVNDLin.Columns[5].Width = 100;
                    dgvDocumentoVNDLin.Columns[6].Width = 100;
                    dgvDocumentoVNDLin.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
                    dgvDocumentoVNDLin.DefaultCellStyle.Font = new Font("Arial", 10);
                    dgvDocumentoVNDLin.RowsDefaultCellStyle.Font = new Font("Arial", 10);
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar as linhas {ex.Message}");
            }
        }

        /// <summary>
        ///     Vai buscar o Id da Linha selecionada - Vai ser usado para criar a RI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDocumentoLin_CellContextMenuStripNeeded(object sender,
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            try
            {
                var dgv = (DataGridView) sender;

                if (e.RowIndex == -1 || e.ColumnIndex == -1)
                    return;

                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    int linha = (short) row.Cells["Linha"].Value;

                    var query =
                        $"SELECT CDU_Id FROM TDU_TRT_LinhasDocumentos WHERE CDU_NumLinha = '{linha}' AND CDU_IdDoc = '{IdOrig}'  ";
                    var lstQ = PriEngine.Engine.Consulta(query);

                    if (lstQ.NumLinhas() == 0) return;
                    IdLin = lstQ.Valor(0);
                }

                e.ContextMenuStrip = cmsVND;
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar as linhas {ex.Message}");
            }
        }

        /// <summary>
        ///     Vai criar o documento RI com os valores da linha selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CriarReqInternaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //var query = "";
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            try
            {
                var documento = "RI";
                var serie = DateTime.Now.Year.ToString();
                var data = DateTime.Now;
                var processo = cbPRONumProcesso.Text;

                var vendas = new IntegraPrimavera();

                using var sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();

                using (var transaction = sqlCon.BeginTransaction())
                {
                    vendas.CriaDocumento(documento, serie, data, processo, processo, sqlCon, transaction, IdOrig,
                        IdLin, "", 0);
                    vendas.ConvertLinhas(IdLin, sqlCon, transaction);
                    vendas.CriaAprovacao( documento, serie, processo, sqlCon, transaction);
                    transaction.Commit();
                }

                LimpaGrelhaRi();
                LimpaGrelhaVnd();
                PopulaGrelhaRi(cbPRONumProcesso.Text);
                PopulaGrelhaVnd(cbPRONumProcesso.Text);
                PriEngine.Platform.Dialogos.MostraAviso("Documento criado com sucesso.");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso(
                    $"Erro ao criar a RI: {ex.Message}.");
            }
        }

        /// <summary>
        ///     Vai abrir a FrmRecibo e passar o Id do documento selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CriarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var recibo = new FrmRecibo(IdCab, cbPRONumProcesso.Text);
                recibo.Show(this);
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso(
                    $"Erro ao criar o Recibo: {ex.Message}.");
            }

            LimpaGrelhaRi();
            LimpaGrelhaVndLin();
            LimpaGrelhaVnd();
            PopulaGrelhaRi(cbPRONumProcesso.Text);
            PopulaGrelhaVnd(cbPRONumProcesso.Text);
        }

        #endregion

    }
}
