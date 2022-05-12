using System;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmDocumento : Form
    {
        #region Form

        public FrmDocumento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form ao abrir preenche os campos necessarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCotacao_Load(object sender, EventArgs e)
        {
            CbDocOperacao.Items.Clear();

            if (BtnDocConverter.Visible)
            {
                CbDocOperacao.Items.Add("Cotação");
            }
            else
            {
                CbDocOperacao.Items.Add("Cotação");
                CbDocOperacao.Items.Add("Requisição de fundos");
                CbDocOperacao.Items.Add("Requisição de fundos adicional");
                CbDocOperacao.Items.Add("Nota de Débito");
                CbDocOperacao.Items.Add("Factura");
                CbDocOperacao.Items.Add("Factura Recibo");
                CbDocOperacao.Items.Add("Factura de Transporte");
                CbDocOperacao.Items.Add("Nota de Crédito");
                CbDocOperacao.Items.Add("Requisição Interna");
            }
        }

        /// <summary>
        /// Insere o numero do documento apos a escolha do documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCotOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            string codDoc = motores.GetCodigoDocumento(CbDocOperacao.Text);
            motores.GetNumeros(CbDocNumOperacao, codDoc);
            motores.GetAnos(CbDocAno);
            CbDocAno.Text = Convert.ToString(DateTime.Now.Year);
            CbDocNumOperacao.Text = Convert.ToString(motores.GetDocumentosNumerador(codDoc));
        }

        /// <summary>
        /// Quando o numero da operaçao alterar carrega a grelha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCotNumOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulaGrelha();

            //depois de carregar os valores pega neles e valida se o doc ja existe.
            var motores = new Motores();
            var documento = motores.GetCodigoDocumento(CbDocOperacao.Text);
            var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(CbDocNumOperacao.Text), Convert.ToInt32(CbDocAno.Text));
            if (existeDoc is true)
            {
                //Carrega os dados da form
                var lstDadosForm = motores.GetDadosForm(documento, Convert.ToInt32(CbDocNumOperacao.Text), Convert.ToInt32(CbDocAno.Text));

                try
                {
                    if (lstDadosForm.Vazia() && lstDadosForm.NoFim()) return;
                    TxtDocCliente.Text = lstDadosForm.Valor(0);
                    TxtDocNomeCliente.Text = lstDadosForm.Valor(1);
                    TxtDocMoeda.Text = lstDadosForm.Valor(2);
                    TxtDocValorCif.Text = Convert.ToString(lstDadosForm.Valor(3));
                    TxtDocValorAduaneiro.Text = Convert.ToString(lstDadosForm.Valor(4));
                    TxtDocCambio.Text = Convert.ToString(lstDadosForm.Valor(5));
                    TxtDocDup.Text = lstDadosForm.Valor(7);
                    TxtDocPorteBl.Text = lstDadosForm.Valor(8);
                    DtpDocData.Text = Convert.ToString(lstDadosForm.Valor(11));
                    TxtDocTipoMercadoria.Text = lstDadosForm.Valor(13);
                    TxtDocTransporte.Text = lstDadosForm.Valor(15);
                    TxtDocDu.Text = lstDadosForm.Valor(19);
                    DtpDocDataDu.Text = Convert.ToString(lstDadosForm.Valor(23));
                    TxtDocTotalSIva.Text = Convert.ToString(lstDadosForm.Valor(25));
                    TxtDocTotalIva.Text = Convert.ToString(lstDadosForm.Valor(26));
                    TxtDocTotalRet.Text = Convert.ToString(lstDadosForm.Valor(27));
                    TxtDocTotalDoc.Text = Convert.ToString(lstDadosForm.Valor(28));
                }
                catch (Exception ex)
                {
                    PriEngine.Platform.MensagensDialogos.MostraAviso($"Erro ao carregar o documento: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Ao alterar o valor da celula faz calculos de iva e valida
        /// se sao numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLinhasDocumentoDoc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Cria o documento e as linhas ao imprmir e depois imprime o documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCotImprimir_Click(object sender, EventArgs e)
        {
            var motores = new Motores();
            var documento = motores.GetCodigoDocumento(CbDocOperacao.Text);
            motores.EnviaImpressao(documento, CbDocNumOperacao.Text, Convert.ToInt32(CbDocAno.Text), CbDocOperacao.Text);
        }

        private void BtnDocConverter_Click(object sender, EventArgs e)
        {
            //Converte a Cotaçao em Req - Copia a CabecDocumentos e LinhasDocumentos
            //Actualiza no Processo o numero do processo
            //carrega a FrmRequisicoes com a REQ criada
            var motores = new Motores();
            var codDoc = motores.GetCodigoDocumento(CbDocOperacao.Text);
            var processo = motores.GeraNumProcesso(TxtDocTransporte.Text);
            var existeReq = motores.ValidaReqConvertidaExiste(codDoc, Convert.ToInt32(CbDocAno.Text), Convert.ToInt32(CbDocNumOperacao.Text));
            var doc = motores.GetReqDocumentoNumAno(codDoc, Convert.ToInt32(CbDocAno.Text), Convert.ToInt32(CbDocNumOperacao.Text));
            if (existeReq is false)
            {
                motores.ConverteCabecDocumento("REQ", codDoc, Convert.ToInt32(CbDocAno.Text), Convert.ToInt32(CbDocNumOperacao.Text), DateTime.Now.Date, processo);
                var novaReq = motores.GetReqDocumentoNumAno(codDoc, Convert.ToInt32(CbDocAno.Text), Convert.ToInt32(CbDocNumOperacao.Text));
                TxtDocNumDocConvertido.Visible = true;
                TxtDocNumDocConvertido.Text = novaReq;
            }
            else
            {
                TxtDocNumDocConvertido.Visible = true;
                if (doc != "false")
                {
                    TxtDocNumDocConvertido.Text = doc;
                }
                PriEngine.Platform.MensagensDialogos.MostraAviso($"O documento que pretende converter ja foi convertido: {doc}");
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
            if (CbDocOperacao.Text != "" && CbDocNumOperacao.Text != "")
                motores.PopulaGrelhaLinhasDoc(dgvLinhasDocumentoDoc, motores.GetCodigoDocumento(CbDocOperacao.Text),
                    Convert.ToInt32(CbDocNumOperacao.Text), Convert.ToInt32(CbDocAno.Text));
        }

        #endregion

        #region Metodos

        /// <summary>
        /// esconde o botao converter
        /// </summary>
        public void DesabilitaBtnConverter(bool visualiza)
        {
            if (visualiza is true)
            {
                BtnDocImprimir.Visible = true;
                BtnDocConverter.Visible = false;
            }
            else
            {
                BtnDocImprimir.Visible = false;
                BtnDocConverter.Visible = true;
            }
        }

        #endregion

    }
}
