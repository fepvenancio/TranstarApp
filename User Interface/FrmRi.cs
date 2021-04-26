using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmRi : Form
    {
        #region form

        public FrmRi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega a lista de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRECCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var motores = new Motores();
            TxtRECNomeCliente.Text = Convert.ToString(motores.GetNomeCliente(CbRECCliente.Text));
            CbRECProcesso.Items.Clear();
            CarregaProcessosCliente();
        }

        /// <summary>
        /// Carrega a lista de processos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRECDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbRECNumero.Items.Clear();
            CbRECAno.Items.Clear();
            CarregaNumAno();
        }

        /// <summary>
        /// Depois de carregar o processo limpa os documentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRECProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbRECProcesso.Text != "")
            {
                var motores = new Motores();
                dgvLinhasDrv = motores.ApagaDadosGrelha(dgvLinhasDrv);
                CbRECDocumento.Text = "";
                CbRECNumero.Text = "";
                CbRECAno.Text = "";
                TxtRECMoeda.Text = "";
                TxtRECCambio.Text = "";
                TxtRECTransporte.Text = "";
                TxtRECBL.Text = "";
                TxtRECNDar.Text = "";
                TxtRECNDu.Text = "";
                TxtRecCriarTotal.Text = "";
                TxtRecCriarTotalIva.Text = "";
                TxtRecCriarTotalRetencao.Text = "";
                TxtRecCriarTotalSIva.Text = "";
                TxtRecTotal.Text = "";
                TxtRECTotalIva.Text = "";
                TxtRECTotalRetencao.Text = "";
                TxtRECTotalSIva.Text = "";
                TxtRECTotalSIva.Text= "";
            }

            CbRECNumero.Items.Clear();
            CbRECAno.Items.Clear();
            CarregaNumAno();
        }

        /// <summary>
        /// Carrega o proximo documento DRV a fazer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRECDocumentoDrv_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbRecNumeroDrv.Items.Clear();
            CbRecAnoDrv.Items.Clear();

            Motores motores = new Motores();
            string codDoc = motores.GetCodigoDocumento(CbRecDocumentoDrv.Text);
            motores.GetNumeros(CbRecNumeroDrv, codDoc);
            motores.GetAnos(CbRecAnoDrv);
            CbRecAnoDrv.Text = Convert.ToString(DateTime.Now.Year);
            CbRecNumeroDrv.Text = Convert.ToString(motores.GetDocumentosNumerador(codDoc));

            ///Valida se aquela RI ja existe se existir carrega os campos
            bool validaSeExiste = motores.ExisteDocumento(CbRecDocumentoDrv.Text, Convert.ToInt32(CbRecNumeroDrv.Text), Convert.ToInt32(CbRecAnoDrv.Text));

            if(validaSeExiste is false) return;
            
        }

        /// <summary>
        /// Ao selecionar o ano ele carrega os dados do documento
        /// Preenche a form e carrega a grelha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRECAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulaGrelha();

            //depois de carregar os valores pega neles e valida se o doc ja existe.
            var motores = new Motores();
            var documento = motores.GetCodigoDocumento(CbRECDocumento.Text);
            var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(CbRECNumero.Text), Convert.ToInt32(CbRECAno.Text));
            if (!(existeDoc is true)) return;
            //Carrega os dados da form
            var lstDadosForm = motores.GetDadosForm(documento, Convert.ToInt32(CbRECNumero.Text), Convert.ToInt32(CbRECAno.Text));

            try
            {
                if (lstDadosForm.Vazia() && lstDadosForm.NoFim()) return;
                CbRECCliente.Text = Convert.ToString(lstDadosForm.Valor(0));
                TxtRECNomeCliente.Text = Convert.ToString(lstDadosForm.Valor(1));
                TxtRECMoeda.Text = Convert.ToString(lstDadosForm.Valor(2));
                TxtRECCambio.Text = Convert.ToString(lstDadosForm.Valor(5));
                TxtRECTransporte.Text = Convert.ToString(lstDadosForm.Valor(15));
                TxtRECBL.Text = Convert.ToString(lstDadosForm.Valor(9));
                TxtRECNDar.Text = Convert.ToString(lstDadosForm.Valor(17));
                TxtRECNDu.Text = Convert.ToString(lstDadosForm.Valor(19));
                TxtRECTotalSIva.Text = Convert.ToString(lstDadosForm.Valor(25), CultureInfo.InvariantCulture);
                TxtRECTotalIva.Text = Convert.ToString(lstDadosForm.Valor(26));
                TxtRECTotalRetencao.Text = Convert.ToString(lstDadosForm.Valor(27));
                TxtRecTotal.Text = Convert.ToString(lstDadosForm.Valor(28));
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar o documento: {ex.Message}");
            }
        }

        /// <summary>
        /// Form ao abrir preenche os campos necessarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRi_Load(object sender, EventArgs e)
        {
            var motores = new Motores();

            CbRECCliente.Items.Clear();
            CbRECProcesso.Items.Clear();
            CbRECDocumento.Items.Clear();
            CbRECNumero.Items.Clear();
            CbRECAno.Items.Clear();

            motores.GetClientes(CbRECCliente);
            motores.GetProcessos(CbRECProcesso);

            CbRECDocumento.Items.Add("Requisição de fundos");
            CbRECDocumento.Items.Add("Requisição de fundos adicional");
            CbRecDocumentoDrv.Items.Add("Requisição Interna");
        }

        private void BtnRecImprime_Click(object sender, EventArgs e)
        {
            try
            {
                //deve validar campos obrigatorios
                //deve alterar as virgulas por pontos(SQL)
                //valida se o documento existe
                //Cria o documento e as linhas
                //aumenta o numerador do documento
                var motores = new Motores();
                var grelhaNumLinhas = motores.ValidaGrelhaNumLinhas(dgvLinhasDrv);
                var valorRec = 0;

                if (grelhaNumLinhas is true)
                {
                    //Precisa calcular os totais pela soma das linhas da grelha
                    //Precisa de ir a ficha do cliente buscar varios dados
                    // dados da ficha e saber se: IVa Cativo ou Retençao
                    var valoresTotais = motores.GetTotaisGrelha(dgvLinhasDrv);
                    var valorDoc = valoresTotais[0];
                    var valorIva = valoresTotais[1];
                    var valorTot = valorDoc + valorIva;
                    double valorRet = 0;
                    var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                    var cliente = CbRECCliente.Text;
                    var dadosCliente = motores.GetDadosCliente(cliente);

                    var nome = dadosCliente[0];
                    var nif = dadosCliente[1];
                    var morada = dadosCliente[2];
                    var localidade = dadosCliente[3];
                    var codPostal = dadosCliente[4];
                    var codPostalLocalidade = dadosCliente[5];
                    var pais = dadosCliente[6];
                    var ivaCativo = Convert.ToBoolean(dadosCliente[7]);
                    var retencao = Convert.ToBoolean(dadosCliente[8]);

                    if (retencao is true)
                    {
                        var percRet = motores.GetPercRetencao(cliente);
                        valorRet = valorTot * percRet;
                    }

                    bool validaCamposObrigatoriosDrv = this.validaCamposObrigatoriosDrv();
                    if (validaCamposObrigatoriosDrv is true)
                    {
                        var id = Guid.NewGuid();
                        var cambio = motores.AlteraPontosPorVirgulas(TxtRECCambio.Text);
                        motores.CriaCabecDocumento(
                            id,
                            Convert.ToString("RI"),
                            Convert.ToInt32(CbRecAnoDrv.Text),
                            Convert.ToInt32(CbRecNumeroDrv.Text),
                            Convert.ToDateTime(DateTime.Now.Date),
                            Convert.ToString(TxtRECMoeda.Text),
                            Convert.ToDouble(cambio),
                            Convert.ToString(""),
                            Convert.ToString(CbRECProcesso.Text),
                            Convert.ToString(""),
                            Convert.ToString(""),
                            Convert.ToDouble(valorDoc),
                            Convert.ToDouble(valorIva),
                            Convert.ToDouble(valorRet),
                            Convert.ToDouble(valorTot),
                            Convert.ToDouble(valorRec),
                            Convert.ToString(utilizador),
                            Convert.ToString(cliente),
                            Convert.ToString(nome),
                            Convert.ToString(nif),
                            Convert.ToString(morada),
                            Convert.ToString(localidade),
                            Convert.ToString(codPostal),
                            Convert.ToString(codPostalLocalidade),
                            Convert.ToString(pais),
                            Convert.ToBoolean(ivaCativo),
                            Convert.ToBoolean(retencao),
                            dgvLinhasDrv);

                        motores.EnviaImpressao("RI", CbRECNumero.Text, Convert.ToInt32(CbRECAno.Text), "Requisição Interna");
                        motores.ApagaDadosForm(this);
                    }
                    else
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Devem preencher os campos obrigatorios: " +
                                                                "Processo, " +
                                                                "Documento a Receber, " +
                                                                "Numero, " +
                                                                "Ano, ");
                    }

                    motores.EnviaImpressao("RI", CbRECNumero.Text, Convert.ToInt32(CbRECAno.Text), "Requisição Interna");
                    LimpaForm();
                }
                else
                {
                    PriEngine.Platform.Dialogos.MostraAviso($"Deve adicionar linhas (Items) ao documento!");
                }
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar o documento: {ex.Message}");
            }
        }

        //Limpa a form e carrega os campos necessarios.
        private void BtnDrvLimpar_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private void LimpaForm()
        {
            var motores = new Motores();
            motores.ApagaDadosForm(this);
            dgvLinhasDrv = motores.ApagaDadosGrelha(dgvLinhasDrv);
            CbRECCliente.Items.Clear();
            CbRECProcesso.Items.Clear();
            CbRECDocumento.Items.Clear();
            CbRECNumero.Items.Clear();
            CbRECAno.Items.Clear();

            motores.GetClientes(CbRECCliente);
            motores.GetProcessos(CbRECProcesso);

            CbRECDocumento.Items.Add("Requisição de fundos");
            CbRECDocumento.Items.Add("Requisição de fundos adicional");
            CbRecDocumentoDrv.Items.Add("Requisição Interna");
        }

        private void dgvLinhasDrv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalSIva = 0;
            double iva = 0;
            double total = 0;
            TxtRecCriarTotalSIva.Text = Convert.ToString(0, CultureInfo.InvariantCulture);
            TxtRecCriarTotalIva.Text = Convert.ToString(0, CultureInfo.InvariantCulture);
            TxtRecCriarTotal.Text = Convert.ToString(0, CultureInfo.InvariantCulture);

            foreach (DataGridViewRow row in dgvLinhasDrv.Rows)
            {
                if (row.Cells["Escolher"].Value is true)
                {
                    totalSIva += Convert.ToDouble(row.Cells["Valor"].Value);
                    iva += Convert.ToDouble(row.Cells["Valor Iva"].Value);
                    total = totalSIva + iva;
                }
            }

            TxtRecCriarTotalSIva.Text = Convert.ToString(totalSIva, CultureInfo.InvariantCulture);
            TxtRecCriarTotalIva.Text = Convert.ToString(iva, CultureInfo.InvariantCulture);
            TxtRecCriarTotal.Text = Convert.ToString(total, CultureInfo.InvariantCulture);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Valida os campos a preencher antes de gravar a DRV
        /// </summary>
        /// <returns></returns>
        private bool validaCamposObrigatoriosDrv()
        {
            return CbRECProcesso.Text != ""
                   && CbRecDocumentoDrv.Text != ""
                   && CbRecNumeroDrv.Text != ""
                   && CbRecAnoDrv.Text != ""
                   && CbRECDocumento.Text != ""
                   && CbRECNumero.Text != ""
                   && CbRECAno.Text != "";
        }

        /// <summary>
        /// Apos a escolha do processo carrega e o documento carrega
        /// os numeros e os anos dos documentos. 
        /// </summary>
        private void CarregaNumAno()
        {
            var motores = new Motores();
            var codDoc = motores.GetCodigoDocumento(CbRECDocumento.Text);
            var sqlQ = new StringBuilder();
            sqlQ.Append("SELECT CDU_Numero, CDU_Ano ");
            sqlQ.Append("FROM TDU_TRT_CabecDocumentos ");
            sqlQ.Append($"WHERE CDU_Processo = '{CbRECProcesso.Text}' ");
            sqlQ.Append($"AND CDU_Documento = '{codDoc}' ");
            var query = sqlQ.ToString();
            var lstQ = PriEngine.Engine.Consulta(query);
            CbRECNumero.Items.Clear();
            CbRECAno.Items.Clear();
            if (lstQ.Vazia() && !lstQ.NoFim()) return;
            while (!lstQ.NoFim())
            {
                CbRECNumero.Items.Add(lstQ.Valor(0));
                CbRECAno.Items.Add(lstQ.Valor(1));
                lstQ.Seguinte();
            }
        }

        /// <summary>
        /// Apos a escolha do cliente carrega apenas os processos
        /// do mesmo.
        /// </summary>
        private void CarregaProcessosCliente()
        {
            var sqlQ = new StringBuilder();
            sqlQ.Append("SELECT CDU_Processo ");
            sqlQ.Append("FROM TDU_TRT_CabecDocumentos ");
            sqlQ.Append($"WHERE CDU_Cliente = '{CbRECCliente.Text}' ");
            sqlQ.Append($"AND CDU_Documento = 'REQ' ");
            var query = sqlQ.ToString();
            var lstQ = PriEngine.Engine.Consulta(query);
            CbRECProcesso.Items.Clear();
            if (lstQ.Vazia() && !lstQ.NoFim()) return;
            while (!lstQ.NoFim())
            {
                CbRECProcesso.Items.Add(lstQ.Valor(0));
                lstQ.Seguinte();
            }
        }


        #endregion

        #region Grelha

        /// <summary>
        /// Popula a grelha com os items
        /// </summary>
        private void PopulaGrelha()
        {
            var motores = new Motores();
            if (CbRECProcesso.Text != "" && CbRECDocumento.Text != "" && CbRECNumero.Text != "" && CbRECAno.Text != "")
                motores.PopulaGrelhaLinhasDoc(dgvLinhasDrv, motores.GetCodigoDocumento(CbRECDocumento.Text),
                    Convert.ToInt32(CbRECNumero.Text), Convert.ToInt32(CbRECAno.Text));
        }


        #endregion
    }
}
