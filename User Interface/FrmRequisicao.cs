using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmRequisicao : Form
    {
        #region variaveis

        private readonly string _cliente;

        private readonly DateTime _data;

        private readonly double _cambio;

        public string ProcessoReq { get; private set; }

        private string Simulacao { get; }

        #endregion

        #region Form

        public FrmRequisicao(string strCliente, DateTime dtpData, double fltCambio, string strSimulacao)
        {
            _cliente = strCliente;
            _data = dtpData.Date;
            _cambio = fltCambio;
            Simulacao = strSimulacao;

            InitializeComponent();
        }

        private void FrmRequisao_Load(object sender, EventArgs e)
        {
            // valores do combobox
            cbSERFRMREQTipoProc.Items.Add("Marítimo");
            cbSERFRMREQTipoProc.Items.Add("Aéreo");
            cbSERFRMREQTipoProc.Items.Add("Terrestre");

            // data de hoje
            dtpSERFRMREQData.Value = _data.Date;

            // cambio
            txtSERFRMREQCambio.Text = _cambio.ToString(CultureInfo.InvariantCulture);

            // cliente
            ActualizaDadosClienteReq();
            cbSERFRMREQCliente.Text = _cliente;
        }

        private void BtnSERFRMREQCria_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                if (txtSERFRMREQREQExistente.Text == "")
                {
                    if (cbSERFRMREQCliente.Text != "" || cbSERFRMREQCliente.Text != @"VD")
                    {
                        var documento = "REQ";
                        var serie = _data.Year.ToString();
                        ProcessoReq = txtSERFRMREQProcesso.Text;
                        var vendas = new IntegraPrimavera();
                        var idOrig = Guid.NewGuid();
                        var idLin = Guid.NewGuid();

                        if (txtSERFRMREQREQExistente.Text == "")
                        {
                            using (var sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();

                                using (var transaction = sqlCon.BeginTransaction())
                                {
                                    vendas.CriaProcesso(ProcessoReq, Simulacao, sqlCon, transaction);
                                    vendas.CriaDocumento(documento, serie, _data, ProcessoReq, Simulacao,
                                        sqlCon, transaction, idOrig, idLin, "", 0);
                                    transaction.Commit();
                                }

                                sqlCon.Close();
                            }
                            
                            using (var sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();

                                using var transaction = sqlCon.BeginTransaction();
                                vendas.CriaDocumentoErp(documento, _cliente, _data, _cambio, serie,
                                    ProcessoReq);
                                transaction.Commit();
                            }

                            PriEngine.Platform.Dialogos.MostraAviso("Documento criado com sucesso.");
                            IntegraPrimavera.PrintInvoice();
                            Close();
                        }
                    }
                    else
                    {
                        PriEngine.Platform.Dialogos.MostraAviso(
                            "O cliente não deve ser nulo ou VD, altere o cliente por favor. ");
                    }
                }
                else
                {
                    PriEngine.Platform.Dialogos.MostraAviso(
                        "Já existe uma requisição, deve proceder a criação de uma RQA - Requisição Adicional");
                }
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso("erro ao criar a REQ no ERP: " + ex.Message);
            }
        }

        private void CbSERFRMREQTipoProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GeraProcesso();

            var documento = "REQ";
            var vendas = new IntegraPrimavera();

            var numReq = vendas.ExisteReq(Simulacao, documento);

            if (numReq != "vazio") txtSERFRMREQREQExistente.Text = numReq;
        }

        private void CbSERFRMREQCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nomeCliente = new IntegraPrimavera();
            txtSERFRMREQNomeCliente.Text = nomeCliente.NomeCliente(cbSERFRMREQCliente.Text);
        }

        #endregion

        #region metodos

        private void GeraProcesso()
        {
            var sql = new StringBuilder();
            var tipoProc = string.Empty;
            var ano = DateTime.Now.Year.ToString();
            var substring = ano.Substring(ano.Length - 2);

            switch (cbSERFRMREQTipoProc.Text)
            {
                case "Marítimo":
                    tipoProc = "1";
                    break;
                case "Aéreo":
                    tipoProc = "2";
                    break;
                case "Terrestre":
                    tipoProc = "3";
                    break;
            }

            var processo = substring + tipoProc + "%";

            sql.Append("SELECT MAX(RIGHT(CDU_Codigo, 4)) ");
            sql.Append("FROM [dbo].[TDU_TRT_Processo] ");
            sql.Append("WHERE CDU_Codigo LIKE '" + processo + "' ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia() || lstPesquisa.Valor(0).ToString() == "")
            {
                processo = substring + tipoProc + "0001";
                txtSERFRMREQProcesso.Text = processo;
            }
            else
            {
                int maxCodigo = Convert.ToInt32(lstPesquisa.Valor(0)) + 1;
                processo = string.Empty;

                if (maxCodigo.ToString().Length == 1)
                    processo = substring + tipoProc + "000" + maxCodigo;
                else if (maxCodigo.ToString().Length == 2)
                    processo = substring + tipoProc + "00" + maxCodigo;
                else if (maxCodigo.ToString().Length == 3) processo = substring + tipoProc + "0" + maxCodigo;

                txtSERFRMREQProcesso.Text = processo;
            }
        }

        private void ActualizaDadosClienteReq()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Cliente ");
            sql.Append("FROM [dbo].[Clientes] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbSERFRMREQCliente.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbSERFRMREQCliente.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }

        #endregion
    }
}
