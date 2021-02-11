using System;
using System.Globalization;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmRequisicoes : Form
    {
        #region Form

        public FrmRequisicoes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form ao abrir preenche os campos necessarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRequisicoes_Load(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            motores.GetTipoServ(CbReqTServico);
            motores.GetClientes(CbReqCliente);
            motores.GetDadosTransporte(CbReqTransporte);
            motores.GetMoedas(CbReqMoeda);
            motores.GetProcessos(CbReqNumProcesso);

            CbReqOperacao.Items.Clear();
            CbReqOperacao.Items.Add("Requisição de fundos");
            CbReqOperacao.Items.Add("Requisição de fundos adicional");
        }

        /// <summary>
        /// Insere o numero do documento apos a escolha do documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbReqOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            string codDoc = motores.GetCodigoDocumento(CbReqOperacao.Text);
            motores.GetNumeros(CbReqNumOperacao, codDoc);
            motores.GetAnos(CbReqAno);
            CbReqAno.Text = Convert.ToString(DateTime.Now.Year);
            CbReqNumOperacao.Text = Convert.ToString(motores.GetDocumentosNumerador(codDoc));
        }

        /// <summary>
        /// Insere o numero do processo a ser criado com base no transporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbReqTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var motores = new Motores();
            
            if (CbReqOperacao.Text == "Requisição de fundos")
            {
                CbReqNumProcesso.Text = motores.GeraNumProcesso(CbReqTransporte.Text);
            }
        }

        /// <summary>
        /// Devolve o nome do cliente apos escolher o codigo de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbReqCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            TxtReqNomeCliente.Text = motores.GetNomeCliente(CbReqCliente.Text);
        }

        /// <summary>
        /// Actualiza automaticamente o cambio baseado no cambio do ERP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbReqMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            TxtReqCambio.Text = Convert.ToString(motores.GetMoedaCambio(CbReqMoeda.Text), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Limpa a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReqLimpaForm_Click(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            motores.ApagaDadosForm(this);
            dgvLinhasDocumentosReq = motores.ApagaDadosGrelha(dgvLinhasDocumentosReq);
            motores.GetTipoServ(CbReqTServico);
            motores.GetClientes(CbReqCliente);
            motores.GetDadosTransporte(CbReqTransporte);
            motores.GetMoedas(CbReqMoeda);

            CbReqOperacao.Items.Clear();
            CbReqOperacao.Items.Add("Requisição de fundos");
            CbReqOperacao.Items.Add("Requisição de fundos adicional");
        }

        /// <summary>
        /// Quando o numero da operaçao alterar carrega a grelha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbReqNumOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulaGrelha();

            //depois de carregar os valores pega neles e valida se o doc ja existe.
            var motores = new Motores();
            var documento = motores.DevolveDocumento(CbReqOperacao.Text);
            var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(CbReqNumOperacao.Text), Convert.ToInt32(CbReqAno.Text));
            if (existeDoc is true)
            {
                //Carrega os dados da form
                var lstDadosForm = motores.GetDadosForm(documento, Convert.ToInt32(CbReqNumOperacao.Text), Convert.ToInt32(CbReqAno.Text));

                try
                {
                    if (lstDadosForm.Vazia() && lstDadosForm.NoFim()) return;
                    CbReqCliente.Text = lstDadosForm.Valor(0);
                    TxtReqNomeCliente.Text = lstDadosForm.Valor(1);
                    CbReqMoeda.Text = lstDadosForm.Valor(2);
                    TxtReqValorCIF.Text = Convert.ToString(lstDadosForm.Valor(3));
                    TxtReqValorAduaneiro.Text = Convert.ToString(lstDadosForm.Valor(4));
                    TxtReqCambio.Text = Convert.ToString(lstDadosForm.Valor(5));
                    TxtReqCNCA.Text = lstDadosForm.Valor(6);
                    TxtReqDUP.Text = lstDadosForm.Valor(7);
                    TxtReqPorteBL.Text = lstDadosForm.Valor(8);
                    TxtReqRUP.Text = lstDadosForm.Valor(9);
                    TxtReqVReferencia.Text = lstDadosForm.Valor(10);
                    DtpReqData.Text = Convert.ToString(lstDadosForm.Valor(11));
                    DtpReqDataChegada.Text = Convert.ToString(lstDadosForm.Valor(12));
                    TxtReqTipoMercadoria.Text = lstDadosForm.Valor(13);
                    TxtRetObs.Text = lstDadosForm.Valor(14);
                    CbReqTransporte.Text = lstDadosForm.Valor(15);
                    TxtReqManifesto.Text = lstDadosForm.Valor(16);
                    TxtReqDar.Text = lstDadosForm.Valor(17);
                    TxtReqValorDar.Text = lstDadosForm.Valor(18);
                    TxtReqDU.Text = lstDadosForm.Valor(19);
                    TxtReqNumVolumes.Text = lstDadosForm.Valor(20);
                    DtpReqDataEntrada.Text = Convert.ToString(lstDadosForm.Valor(21));
                    DtpReqDataSaida.Text = Convert.ToString(lstDadosForm.Valor(22));
                    DtpReqDataDu.Text = Convert.ToString(lstDadosForm.Valor(23));
                    TxtReqPesoKGs.Text = Convert.ToString(lstDadosForm.Valor(24));
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
        private void dgvLinhasDocReq_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //validar se é número - Como o campo é double ele valida
            //calcular o iva e atribuir
            //coluna Escolher passa a verdadeiro
            var motores = new Motores();

            if (dgvLinhasDocumentosReq.Rows[e.RowIndex].Cells["Valor"].Value == DBNull.Value)
            {
                dgvLinhasDocumentosReq.Rows[e.RowIndex].Cells["Valor"].Value = 0;
            }

            if (dgvLinhasDocumentosReq.Columns[e.ColumnIndex].Name != "Valor") return;

            var valor = Convert.ToDouble(dgvLinhasDocumentosReq.Rows[e.RowIndex].Cells["Valor"].Value);
            var validaIva = Convert.ToString(dgvLinhasDocumentosReq.Rows[e.RowIndex].Cells["Item"].Value);
            var temIva = motores.ValidaSeItemTemIva(validaIva);

            if (temIva)
            {
                //Valida a % de IVA
                //atribui o valor a celula
                var item = motores.GetItem(validaIva);
                var percIva = motores.PercentagemIva(item);
                dgvLinhasDocumentosReq.Rows[e.RowIndex].Cells["Valor Iva"].Value = Math.Round(valor * (percIva / 100), 2, MidpointRounding.ToEven);
            }

            if (valor > 0)
                dgvLinhasDocumentosReq.Rows[e.RowIndex].Cells["Escolher"].Value = true;
        }

        /// <summary>
        /// Cria o documento e as linhas ao imprmir e depois imprime o documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReqImprimir_Click(object sender, EventArgs e)
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
                AlteraPontosPorVirgulas();
                var documento = motores.DevolveDocumento(CbReqOperacao.Text);
                var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(CbReqNumOperacao.Text),
                    Convert.ToInt32(CbReqAno.Text));
                var grelhaNumLinhas = motores.ValidaGrelhaNumLinhas(dgvLinhasDocumentosReq);
                var valorRec = 0;

                if (grelhaNumLinhas is true)
                {
                    if (existeDoc is false)
                    {
                        var existeReq = motores.ValidaRequisicaoProcessoExiste(CbReqNumProcesso.Text);
                        if (existeReq is false)
                        {
                            //Precisa calcular os totais pela soma das linhas da grelha
                            //Precisa de ir a ficha do cliente buscar varios dados
                            // dados da ficha e sabes se: IVa Cativo ou Retençao
                            var valoresTotais = motores.GetTotaisGrelha(dgvLinhasDocumentosReq);
                            var valorDoc = valoresTotais[0];
                            var valorIva = valoresTotais[1];
                            var valorTot = valorDoc + valorIva;
                            double valorRet = 0;
                            var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                            var cliente = CbReqCliente.Text;
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

                            var cotacao = "COT " + CbReqNumOperacao.Text + "/" + CbReqAno.Text;
                            var moeda = CbReqMoeda.Text;
                            var valorCif = Convert.ToDouble(TxtReqValorCIF.Text);
                            var valorAdu = Convert.ToDouble(TxtReqValorAduaneiro.Text);
                            var valorCambio = Convert.ToDouble(TxtReqCambio.Text);
                            var cnca = TxtReqCNCA.Text;
                            var dup = TxtReqDUP.Text;
                            var bl = TxtReqPorteBL.Text;
                            var rup = TxtReqRUP.Text;
                            var referencia = TxtReqVReferencia.Text;
                            var data = DtpReqData.Value;
                            var dataChegada = DtpReqDataChegada.Value;
                            var tipoMerc = TxtReqTipoMercadoria.Text;
                            var obs = TxtRetObs.Text;
                            var transporte = CbReqTransporte.Text;
                            var manifesto = TxtReqManifesto.Text;
                            var numDar = TxtReqDar.Text;
                            var valorDar = TxtReqValorDar.Text;
                            var du = TxtReqDU.Text;
                            var numVolumes = TxtReqNumVolumes.Text;
                            var dataEntrada = DtpReqDataEntrada.Value;
                            var dataSaida = DtpReqDataSaida.Value;
                            var dataDu = DtpReqDataDu.Value;
                            double peso;

                            if (TxtReqPesoKGs.Text == "")
                            {
                                peso = 0;
                            }
                            else
                            {
                                peso = Convert.ToDouble(TxtReqPesoKGs.Text);
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
                                    CbReqNumProcesso.Text,
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
                                    Convert.ToInt32(CbReqAno.Text),
                                    Convert.ToInt32(CbReqNumOperacao.Text),
                                    Convert.ToDateTime(DateTime.Now.Date),
                                    Convert.ToString(CbReqMoeda.Text),
                                    Convert.ToDouble(TxtReqCambio.Text),
                                    Convert.ToString(TxtRetObs.Text),
                                    Convert.ToString(CbReqNumProcesso.Text),
                                    Convert.ToString(cotacao),
                                    Convert.ToString(CbReqTServico.Text),
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
                                    dgvLinhasDocumentosReq);

                                motores.ApagaDadosForm(dgvLinhasDocumentosReq);
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
                            PriEngine.Platform.Dialogos.MostraAviso("Já existe uma REQ para esse processo. Deve criar uma RQA.");
                        }
                    }
                    else
                    {
                        //Deve simplesmente imprimir
                        motores.ApagaDadosForm(dgvLinhasDocumentosReq);
                    }        
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

        #endregion

        #region Grelha

        /// <summary>
        /// Popula a grelha com os items
        /// </summary>
        private void PopulaGrelha()
        {
            var motores = new Motores();
            if (CbReqOperacao.Text != "" && CbReqNumOperacao.Text != "")
                motores.PopulaGrelha(dgvLinhasDocumentosReq, motores.GetCodigoDocumento(CbReqOperacao.Text),
                    Convert.ToInt32(CbReqNumOperacao.Text), Convert.ToInt32(CbReqAno.Text));
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Serve para validar se para criar X documentos os campos essenciais estao preenchidos.
        /// </summary>
        private bool ValidaCamposObrigatorios()
        {
            return CbReqTServico.Text != ""
                   && CbReqOperacao.Text != ""
                   && CbReqCliente.Text != ""
                   && CbReqMoeda.Text != ""
                   && TxtReqValorCIF.Text != ""
                   && TxtReqValorAduaneiro.Text != ""
                   && TxtReqCambio.Text != ""
                   && TxtReqTipoMercadoria.Text != ""
                   && CbReqTransporte.Text != "";
        }

        /// <summary>
        /// Altera virgulas por pontos
        /// </summary>
        private void AlteraPontosPorVirgulas()
        {
            var motores = new Motores();
            motores.ValidaSeTextBoxENumerica(TxtReqValorCIF);
            motores.ValidaSeTextBoxENumerica(TxtReqValorAduaneiro);
            motores.ValidaSeTextBoxENumerica(TxtReqCambio);
            motores.ValidaSeTextBoxENumerica(TxtReqValorDar);
        }


        #endregion

        
    }
}
