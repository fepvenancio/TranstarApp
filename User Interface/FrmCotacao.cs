using System;
using System.Globalization;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmCotacao : Form
    {
        #region Form

        public FrmCotacao()
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
            Motores motores = new Motores();
            motores.GetTipoServ(cbCotTServico);
            motores.GetClientes(cbCotCliente);
            motores.GetDadosTransporte(CbCotTransporte);
            motores.GetMoedas(CbCotMoeda);
            
            cbCotOperacao.Items.Clear();
            cbCotOperacao.Items.Add("Cotação");
        }

        /// <summary>
        /// Insere o numero do documento apos a escolha do documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCotOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            string codDoc = motores.GetCodigoDocumento(cbCotOperacao.Text);
            motores.GetNumeros(cbCotNumOperacao, codDoc);
            motores.GetAnos(CbCotAno);
            CbCotAno.Text = Convert.ToString(DateTime.Now.Year);
            cbCotNumOperacao.Text = Convert.ToString(motores.GetDocumentosNumerador(codDoc));
        }

        /// <summary>
        /// Devolve o nome do cliente apos escolher o codigo de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCotCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            TxtCotNomeCliente.Text = motores.GetNomeCliente(cbCotCliente.Text);
        }

        /// <summary>
        /// Actualiza automaticamente o cambio baseado no cambio do ERP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCotMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            txtCotCambio.Text = Convert.ToString(motores.GetMoedaCambio(CbCotMoeda.Text), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Limpa a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCotLimpaForm_Click(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            motores.ApagaDadosForm(this);
            dgvItemsServicosCOT = motores.ApagaDadosGrelha(dgvItemsServicosCOT);
            motores.GetTipoServ(cbCotTServico);
            motores.GetClientes(cbCotCliente);
            motores.GetDadosTransporte(CbCotTransporte);
            motores.GetMoedas(CbCotMoeda);
            
            cbCotOperacao.Items.Clear();
            cbCotOperacao.Items.Add("Cotação");
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
            var documento = motores.GetCodigoDocumento(cbCotOperacao.Text);
            var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(cbCotNumOperacao.Text), Convert.ToInt32(CbCotAno.Text));
            if (existeDoc is true)
            {
                //Carrega os dados da form
                var lstDadosForm = motores.GetDadosForm(documento, Convert.ToInt32(cbCotNumOperacao.Text), Convert.ToInt32(CbCotAno.Text));

                try
                {
                    if (lstDadosForm.Vazia() && lstDadosForm.NoFim()) return;
                    cbCotCliente.Text = lstDadosForm.Valor(0);
                    TxtCotNomeCliente.Text = lstDadosForm.Valor(1);
                    CbCotMoeda.Text = lstDadosForm.Valor(2);
                    txtCotValorCIF.Text = Convert.ToString(lstDadosForm.Valor(3));
                    txtCotValorAduaneiro.Text = Convert.ToString(lstDadosForm.Valor(4));
                    txtCotCambio.Text = Convert.ToString(lstDadosForm.Valor(5));
                    TxtCotCNCA.Text = lstDadosForm.Valor(6);
                    TxtCotDUP.Text = lstDadosForm.Valor(7);
                    txtCotPorteBL.Text = lstDadosForm.Valor(8);
                    TxtCotRUP.Text = lstDadosForm.Valor(9);
                    txtCotVReferencia.Text = lstDadosForm.Valor(10);
                    DtpCotData.Text = Convert.ToString(lstDadosForm.Valor(11));
                    dtpCotDataChegada.Text = Convert.ToString(lstDadosForm.Valor(12));
                    TxtCotTipoMercadoria.Text = lstDadosForm.Valor(13);
                    TxtCotObs.Text = lstDadosForm.Valor(14);
                    CbCotTransporte.Text = lstDadosForm.Valor(15);
                    TxtCotManifesto.Text = lstDadosForm.Valor(16);
                    txtCotDar.Text = lstDadosForm.Valor(17);
                    TxtCotValorDar.Text = lstDadosForm.Valor(18);
                    TxtCotDU.Text = lstDadosForm.Valor(19);
                    TxtCotNumVolumes.Text = lstDadosForm.Valor(20);
                    DtpCotDataEntrada.Text = Convert.ToString(lstDadosForm.Valor(21));
                    DtpCotDataSaida.Text = Convert.ToString(lstDadosForm.Valor(22));
                    DtpCotDataDu.Text = Convert.ToString(lstDadosForm.Valor(23));
                    TxtPesoKGs.Text = Convert.ToString(lstDadosForm.Valor(24));
                }
                catch(Exception ex)
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
        private void dgvItemsServicosCOT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //validar se é número - Como o campo é double ele valida
            //calcular o iva e atribuir
            //coluna Escolher passa a verdadeiro
            var motores = new Motores();

            if (dgvItemsServicosCOT.Rows[e.RowIndex].Cells["Valor"].Value == DBNull.Value)
            { 
                dgvItemsServicosCOT.Rows[e.RowIndex].Cells["Valor"].Value = 0;
            }

            if (dgvItemsServicosCOT.Columns[e.ColumnIndex].Name != "Valor") return;

            var valor = Convert.ToDouble(dgvItemsServicosCOT.Rows[e.RowIndex].Cells["Valor"].Value);
            var validaIva = Convert.ToString(dgvItemsServicosCOT.Rows[e.RowIndex].Cells["Item"].Value);
            var temIva = motores.ValidaSeItemTemIva(validaIva);

            if (temIva)
            {
                //Valida a % de IVA
                //atribui o valor a celula
                var item = motores.GetItem(validaIva);
                var percIva = motores.PercentagemIva(item);
                dgvItemsServicosCOT.Rows[e.RowIndex].Cells["Valor Iva"].Value = Math.Round(valor * (percIva/100), 2, MidpointRounding.ToEven);
            }

            if(valor > 0)
                dgvItemsServicosCOT.Rows[e.RowIndex].Cells["Escolher"].Value = true;
        }

        /// <summary>
        /// Cria o documento e as linhas ao imprmir e depois imprime o documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCotImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //deve validar campos obrigatorios
                //deve alterar as virgulas por pontos(SQL)
                //valida se o documento existe
                //Cria o documento e as linhas
                //aumenta o numerador do documento
                var motores = new Motores();
                var validaCamposObrigatorios = ValidaCamposObrigatorios();
                var documento = motores.GetCodigoDocumento(cbCotOperacao.Text);
                var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(cbCotNumOperacao.Text),
                    Convert.ToInt32(CbCotAno.Text));
                var grelhaNumLinhas = motores.ValidaGrelhaNumLinhas(dgvItemsServicosCOT);
                var valorRec = 0;

                bool pontoCif = motores.NumerosComPontosNasCasasDecimais(txtCotValorCIF.Text);
                bool pontoAduaneiro = motores.NumerosComPontosNasCasasDecimais(txtCotValorAduaneiro.Text);
                bool pontoCambio = motores.NumerosComPontosNasCasasDecimais(txtCotCambio.Text);
                bool pontoDar = motores.NumerosComPontosNasCasasDecimais(TxtCotValorDar.Text);

                if(pontoCif is true || pontoAduaneiro is true || pontoCambio is true || pontoDar is true)
                {
                    PriEngine.Platform.Dialogos.MostraAviso("Deve trocar o separador das casas decimais para uma vírgula (,)");
                    return;
                }

                if (grelhaNumLinhas is true)
                {
                    if (existeDoc is false)
                    {
                        //Precisa calcular os totais pela soma das linhas da grelha
                        //Precisa de ir a ficha do cliente buscar varios dados
                        // dados da ficha e sabes se: IVa Cativo ou Retençao
                        var valoresTotais = motores.GetTotaisGrelha(dgvItemsServicosCOT);
                        var valorDoc = valoresTotais[0];
                        var valorIva = valoresTotais[1];
                        var valorTot = valorDoc + valorIva;
                        double valorRet = 0;
                        var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                        var cliente = cbCotCliente.Text;
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

                        var cotacao = "COT " + cbCotNumOperacao.Text + "/" + CbCotAno.Text;
                        var moeda = CbCotMoeda.Text;
                        var valorCif = motores.AlteraPontosPorVirgulas(txtCotValorCIF.Text);
                        var valorAdu = motores.AlteraPontosPorVirgulas(txtCotValorAduaneiro.Text);
                        var cambioTxt = txtCotCambio.Text;
                        cambioTxt = cambioTxt.Replace(",", ".");
                        CultureInfo culture = CultureInfo.InvariantCulture;
                        double valorCambio =  motores.AlteraPontosPorVirgulas(txtCotCambio.Text);
                        var cnca = TxtCotCNCA.Text;
                        var dup = TxtCotDUP.Text;
                        var bl = txtCotPorteBL.Text;
                        var rup = TxtCotRUP.Text;
                        var referencia = txtCotVReferencia.Text;
                        var data = DtpCotData.Value;
                        var dataChegada = dtpCotDataChegada.Value;
                        var tipoMerc = TxtCotTipoMercadoria.Text;
                        var obs = TxtCotObs.Text;
                        var transporte = CbCotTransporte.Text;
                        var manifesto = TxtCotManifesto.Text;
                        var numDar = txtCotDar.Text;
                        var valorDar = TxtCotValorDar.Text;
                        var du = TxtCotDU.Text;
                        var numVolumes = TxtCotNumVolumes.Text;
                        var dataEntrada = DtpCotDataEntrada.Value;
                        var dataSaida = DtpCotDataSaida.Value;
                        var dataDu = DtpCotDataDu.Value;
                        double peso;
                        
                        if (TxtPesoKGs.Text == "")
                        {
                            peso = 0;
                        }
                        else
                        {
                            peso = motores.AlteraPontosPorVirgulas(TxtPesoKGs.Text);
                        }

                        if (retencao is true)
                        {
                            var percRet = motores.GetPercRetencao(cliente);
                            valorRet = valorTot * percRet;
                        }

                        if (validaCamposObrigatorios)
                        {
                            var id = Guid.NewGuid();
                            

                            motores.CriaProcesso(
                                cotacao,
                                cliente,
                                nome,
                                moeda,
                                valorCif,
                                valorAdu,
                                valorCambio,
                                cnca,
                                dup,
                                bl,
                                rup,
                                referencia,
                                data,
                                dataChegada,
                                tipoMerc,
                                obs,
                                transporte,
                                manifesto,
                                numDar,
                                valorDar,
                                du,
                                numVolumes,
                                dataEntrada,
                                dataSaida,
                                dataDu,
                                peso
                            );

                            motores.CriaCabecDocumento(
                                id,
                                Convert.ToString(documento),
                                Convert.ToInt32(CbCotAno.Text),
                                Convert.ToInt32(cbCotNumOperacao.Text),
                                Convert.ToDateTime(DateTime.Now.Date),
                                Convert.ToString(CbCotMoeda.Text),
                                Convert.ToDouble(txtCotCambio.Text),
                                Convert.ToString(TxtCotObs.Text),
                                Convert.ToString(""),
                                Convert.ToString(cotacao),
                                Convert.ToString(cbCotTServico.Text),
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
                                Convert.ToString(documento),
                                Convert.ToInt32(0),
                                Convert.ToInt32(0),
                                dgvItemsServicosCOT);

                            motores.EnviaImpressao(documento, cbCotNumOperacao.Text, Convert.ToInt32(CbCotAno.Text), "Cotação");
                            motores.ApagaDadosForm(dgvItemsServicosCOT);
                        }
                        else
                        {
                            PriEngine.Platform.Dialogos.MostraAviso("Devem preencher os campos obrigatorios: " +
                                                                    "Tipo de Serviço, " +
                                                                    "Operacao, " +
                                                                    "Cliente, " +
                                                                    "Moeda, " +
                                                                    "Valor CIF, " +
                                                                    "Valor Aduaneiro, " +
                                                                    "Câmbio, " +
                                                                    "Tipo de Mercadoria " +
                                                                    "e Data de Entrada ");
                        }
                    }
                    else
                    {
                        //Deve simplesmente imprimir
                        motores.EnviaImpressao(documento, cbCotNumOperacao.Text, Convert.ToInt32(CbCotAno.Text), "Cotação");
                        motores.ApagaDadosForm(dgvItemsServicosCOT);
                    }
                }
                else
                {
                    PriEngine.Platform.Dialogos.MostraAviso($"Deve adicionar linhas (Items) ao documento!");
                }
            }
            catch(Exception ex)
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
            if(cbCotOperacao.Text != "" && cbCotNumOperacao.Text != "")
                motores.PopulaGrelhaLinhasDoc(dgvItemsServicosCOT, motores.GetCodigoDocumento(cbCotOperacao.Text), 
                    Convert.ToInt32(cbCotNumOperacao.Text), Convert.ToInt32(CbCotAno.Text));
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Serve para validar se para criar X documentos os campos essenciais estao preenchidos.
        /// </summary>
        private bool ValidaCamposObrigatorios()
        {
            return cbCotTServico.Text != ""
                   && cbCotOperacao.Text != ""
                   && cbCotCliente.Text != ""
                   && CbCotMoeda.Text != ""
                   && txtCotValorCIF.Text != ""
                   && txtCotValorAduaneiro.Text != ""
                   && txtCotCambio.Text != ""
                   && TxtCotTipoMercadoria.Text != ""
                   && CbCotTransporte.Text != "";
        }

        #endregion
    }
}
