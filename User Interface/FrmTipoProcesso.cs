using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmTipoProcesso : Form
    {
        #region Variaveis

        public string ProcessoReq { get; set; }

        private string TipoServ { get; }

        private string Operacao { get; }

        #endregion

        #region Form

        public FrmTipoProcesso(string tipoServ, string operacao)
        {
            TipoServ = tipoServ;
            Operacao = operacao;
            InitializeComponent();
        }

        private void FrmTipoProcesso_Load(object sender, EventArgs e)
        {
            // valores do combobox
            cbSERFRMTPTipoProc.Items.Add("Marítimo");
            cbSERFRMTPTipoProc.Items.Add("Aéreo");
            cbSERFRMTPTipoProc.Items.Add("Terrestre");
        }

        private void CbSERFRMTPTipoProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var numProcesso = string.Empty;
            var geraProcesso = new IntegraPrimavera();

            if (cbSERFRMTPTipoProc.Text != "")
            {
                numProcesso = geraProcesso.GeraProcesso(cbSERFRMTPTipoProc.Text);
                ProcessoReq = numProcesso;
            }

            if (numProcesso != "") txtSERFRMTPProcesso.Text = numProcesso;
        }

        private void BtnSERFRMTPCria_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            var vendas = new IntegraPrimavera();
            ProcessoReq = txtSERFRMTPProcesso.Text;
            var simulacao = "directo";

            try
            {
                using var sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();

                using (var transaction = sqlCon.BeginTransaction())
                {
                    vendas.CriaProcesso(ProcessoReq, simulacao, sqlCon, transaction);
                    vendas.CriaItemsServico(ProcessoReq, TipoServ, Operacao);
                    transaction.Commit();
                }

                PriEngine.Platform.Dialogos.MostraAviso(@"Documento criado com sucesso.");
                Close();
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar a requisição: {ex.Message}");
            }
        }

        #endregion
    }
}
