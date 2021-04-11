using System;
using System.Globalization;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmOutrosDocs : Form
    {
        #region Form

        public FrmOutrosDocs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form ao abrir preenche os campos necessarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOutrosDocs_Load(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            motores.GetClientes(cbOudCliente);
            motores.GetDadosTransporte(CbOudTransporte);
            motores.GetMoedas(CbOudMoeda);
            motores.GetProcessos(cbOudProcesso);

            cbOudOperacao.Items.Clear();
            cbOudOperacao.Items.Add("Factura");
            cbOudOperacao.Items.Add("Factura de Transporte");
            cbOudOperacao.Items.Add("Nota de Débito");
            cbOudOperacao.Items.Add("Nota de Crédito");
        }

        /// <summary>
        /// Insere o numero do documento apos a escolha do documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbOudOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            string codDoc = motores.GetCodigoDocumento(cbOudOperacao.Text);
            motores.GetNumeros(cbOudNumOperacao, codDoc);
            motores.GetAnos(CbOudAno);
            CbOudAno.Text = Convert.ToString(DateTime.Now.Year);
            cbOudNumOperacao.Text = Convert.ToString(motores.GetDocumentosNumerador(codDoc));
        }

        /// <summary>
        /// Devolve o nome do cliente apos escolher o codigo de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbOudCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            TxtOudNomeCliente.Text = motores.GetNomeCliente(cbOudCliente.Text);
        }

        /// <summary>
        /// Actualiza automaticamente o cambio baseado no cambio do ERP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbOudMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            txtOudCambio.Text = Convert.ToString(motores.GetMoedaCambio(CbOudMoeda.Text), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Limpa a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOudLimpaForm_Click(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            motores.ApagaDadosForm(this);
            dgvItemsOud = motores.ApagaDadosGrelha(dgvItemsOud);
            motores.GetProcessos(cbOudProcesso);
            motores.GetClientes(cbOudCliente);
            motores.GetDadosTransporte(CbOudTransporte);
            motores.GetMoedas(CbOudMoeda);

            cbOudOperacao.Items.Clear();
            cbOudOperacao.Items.Add("Factura");
            cbOudOperacao.Items.Add("Factura de Transporte");
            cbOudOperacao.Items.Add("Nota de Débito");
            cbOudOperacao.Items.Add("Nota de Crédito");
        }

        /// <summary>
        /// Quando o numero da operaçao alterar carrega a grelha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOudNumOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulaGrelha();

            //depois de carregar os valores pega neles e valida se o doc ja existe.
            var motores = new Motores();
            var documento = motores.GetCodigoDocumento(cbOudOperacao.Text);
            var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(cbOudNumOperacao.Text), Convert.ToInt32(CbOudAno.Text));
            if (existeDoc is true)
            {
                //Carrega os dados da form
                var lstDadosForm = motores.GetDadosForm(documento, Convert.ToInt32(cbOudNumOperacao.Text), Convert.ToInt32(CbOudAno.Text));

                try
                {
                    if (lstDadosForm.Vazia() && lstDadosForm.NoFim()) return;
                    cbOudCliente.Text = lstDadosForm.Valor(0);
                    TxtOudNomeCliente.Text = lstDadosForm.Valor(1);
                    CbOudMoeda.Text = lstDadosForm.Valor(2);
                    txtOudValorCIF.Text = Convert.ToString(lstDadosForm.Valor(3));
                    txtOudValorAduaneiro.Text = Convert.ToString(lstDadosForm.Valor(4));
                    txtOudCambio.Text = Convert.ToString(lstDadosForm.Valor(5));
                    TxtOudCNCA.Text = lstDadosForm.Valor(6);
                    TxtOudDUP.Text = lstDadosForm.Valor(7);
                    txtOudPorteBL.Text = lstDadosForm.Valor(8);
                    TxtOudRUP.Text = lstDadosForm.Valor(9);
                    txtOudVReferencia.Text = lstDadosForm.Valor(10);
                    DtpOudData.Text = Convert.ToString(lstDadosForm.Valor(11));
                    dtpOudDataChegada.Text = Convert.ToString(lstDadosForm.Valor(12));
                    TxtOudTipoMercadoria.Text = lstDadosForm.Valor(13);
                    TxtOudObs.Text = lstDadosForm.Valor(14);
                    CbOudTransporte.Text = lstDadosForm.Valor(15);
                    TxtOudManifesto.Text = lstDadosForm.Valor(16);
                    txtOudDar.Text = lstDadosForm.Valor(17);
                    TxtOudValorDar.Text = lstDadosForm.Valor(18);
                    TxtOudDU.Text = lstDadosForm.Valor(19);
                    TxtOudNumVolumes.Text = lstDadosForm.Valor(20);
                    DtpOudDataEntrada.Text = Convert.ToString(lstDadosForm.Valor(21));
                    DtpOudDataSaida.Text = Convert.ToString(lstDadosForm.Valor(22));
                    DtpOudDataDu.Text = Convert.ToString(lstDadosForm.Valor(23));
                    TxtOudPesoKGs.Text = Convert.ToString(lstDadosForm.Valor(24));
                }
                catch (Exception ex)
                {
                    PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar o documento: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Ao alterar o valor da celula faz calculos de iva e valida
        /// se sao numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvItemsOud_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //validar se é número - Como o campo é double ele valida
            //calcular o iva e atribuir
            //coluna Escolher passa a verdadeiro
            var motores = new Motores();

            if (dgvItemsOud.Rows[e.RowIndex].Cells["Valor"].Value == DBNull.Value)
            {
                dgvItemsOud.Rows[e.RowIndex].Cells["Valor"].Value = 0;
            }

            if (dgvItemsOud.Columns[e.ColumnIndex].Name != "Valor") return;

            var valor = Convert.ToDouble(dgvItemsOud.Rows[e.RowIndex].Cells["Valor"].Value);
            var validaIva = Convert.ToString(dgvItemsOud.Rows[e.RowIndex].Cells["Item"].Value);
            var temIva = motores.ValidaSeItemTemIva(validaIva);

            if (temIva)
            {
                //Valida a % de IVA
                //atribui o valor a celula
                var item = motores.GetItem(validaIva);
                var percIva = motores.PercentagemIva(item);
                dgvItemsOud.Rows[e.RowIndex].Cells["Valor Iva"].Value = Math.Round(valor * (percIva / 100), 2, MidpointRounding.ToEven);
            }

            if (valor > 0)
                dgvItemsOud.Rows[e.RowIndex].Cells["Escolher"].Value = true;
        }

        /// <summary>
        /// Cria o documento e as linhas ao imprmir e depois imprime o documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOudImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //deve validar campos obrigatorios
                //deve alterar as virgulas por pontos(SQL)
                //valida se o documento existe
                //Cria o documento e as linhas
                //aumenta o numerador do documento
                var motores = new Motores();
                AlteraPontosPorVirgulas();
                var documento = motores.GetCodigoDocumento(cbOudOperacao.Text);
                var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(cbOudNumOperacao.Text),
                    Convert.ToInt32(CbOudAno.Text));

                var valorRec = 0;
                if (existeDoc is false)
                {
                    //Precisa calcular os totais pela soma das linhas da grelha
                    //Precisa de ir a ficha do cliente buscar varios dados
                    // dados da ficha e sabes se: IVa Cativo ou Retençao
                    var valoresTotais = motores.GetTotaisGrelha(dgvItemsOud);
                    var valorDoc = valoresTotais[0];
                    var valorIva = valoresTotais[1];
                    var valorTot = valorDoc + valorIva;
                    double valorRet = 0;
                    var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                    var cliente = cbOudCliente.Text;
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

                    var cotacao = "";

                    if (retencao is true)
                    {
                        var percRet = motores.GetPercRetencao(cliente);
                        valorRet = valorTot * percRet;
                    }

                    var id = Guid.NewGuid();
                    var cambio = motores.AlteraPontosPorVirgulas(txtOudCambio.Text);

                    motores.CriaCabecDocumento(
                        id,
                        Convert.ToString(documento),
                        Convert.ToInt32(CbOudAno.Text),
                        Convert.ToInt32(cbOudNumOperacao.Text),
                        Convert.ToDateTime(DateTime.Now.Date),
                        Convert.ToString(CbOudMoeda.Text),
                        Convert.ToDouble(cambio),
                        Convert.ToString(TxtOudObs.Text),
                        Convert.ToString(cbOudProcesso.Text),
                        Convert.ToString(cotacao),
                        Convert.ToString("Outros"),
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
                        dgvItemsOud);
                }
                else
                {
                    //Deve simplesmente imprimir
                }

                motores.ApagaDadosForm(dgvItemsOud);
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar o documento: {ex.Message}");
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
            if (cbOudOperacao.Text != "" && cbOudNumOperacao.Text != "")
                motores.PopulaGrelhaLinhasDoc(dgvItemsOud, motores.GetCodigoDocumento(cbOudOperacao.Text),
                    Convert.ToInt32(cbOudNumOperacao.Text), Convert.ToInt32(CbOudAno.Text));
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Altera virgulas por pontos
        /// </summary>
        private void AlteraPontosPorVirgulas()
        {
            var motores = new Motores();
            motores.ValidaSeTextBoxENumerica(txtOudValorCIF);
            motores.ValidaSeTextBoxENumerica(txtOudValorAduaneiro);
            motores.ValidaSeTextBoxENumerica(txtOudCambio);
            motores.ValidaSeTextBoxENumerica(TxtOudValorDar);
        }


        #endregion
    }
}
