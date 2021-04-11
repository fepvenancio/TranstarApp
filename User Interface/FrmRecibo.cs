using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmRecibo : Form
    {
        #region Form

        public FrmRecibo()
        {
            InitializeComponent();
        }

        private void lblSERCambio_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Form ao abrir preenche os campos necessarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRecibo_Load(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            motores.GetClientes(CbRecCliente);
            motores.GetMoedas(CbRecMoeda);
            motores.GetProcessos(CbRecProcesso);

            CbRecDocumento.Items.Clear();
            CbRecDocumento.Items.Add("Recibo");
            CbRecDocumento.Text = "Recibo";
        }

        /// <summary>
        /// Insere o numero do documento apos a escolha do documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRecDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            string codDoc = motores.GetCodigoDocumento(CbRecDocumento.Text);
            motores.GetNumeros(CbRecNumero, codDoc);
            motores.GetAnos(CbRecAno);
            CbRecAno.Text = Convert.ToString(DateTime.Now.Year);
            CbRecNumero.Text = Convert.ToString(motores.GetDocumentosNumerador(codDoc));
        }

        /// <summary>
        /// Devolve o nome do cliente apos escolher o codigo de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRecCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var motores = new Motores();
            TxtRecNomeCliente.Text = motores.GetNomeCliente(CbRecCliente.Text);
            CbRecProcesso.Items.Clear();
            motores.GetProcessoCliente(CbRecProcesso, CbRecCliente.Text);
        }

        /// <summary>
        /// Actualiza automaticamente o cambio baseado no cambio do ERP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRecMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            TxtRecCambio.Text = Convert.ToString(motores.GetMoedaCambio(CbRecMoeda.Text), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Limpa a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecLimpaForm_Click(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            motores.ApagaDadosForm(this);
            dgvRecLinhasDocumentos = motores.ApagaDadosGrelha(dgvRecLinhasDocumentos);
            motores.GetProcessos(CbRecProcesso);
            motores.GetClientes(CbRecCliente);
            motores.GetMoedas(CbRecMoeda);

            CbRecDocumento.Items.Clear();
            CbRecDocumento.Items.Add("Recibo");
            CbRecDocumento.Text = "Recibo";
        }

        /// <summary>
        /// Quando o numero da operaçao alterar carrega a grelha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRecNumOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //depois de carregar os valores pega neles e valida se o doc ja existe.
            var motores = new Motores();
            var documento = motores.GetCodigoDocumento(CbRecDocumento.Text);
            var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(CbRecNumero.Text), Convert.ToInt32(CbRecAno.Text));
            if (!(existeDoc is true)) return;
            //Carrega os dados da form
            var lstDadosForm = motores.GetDadosForm(documento, Convert.ToInt32(CbRecNumero.Text), Convert.ToInt32(CbRecAno.Text));

            try
            {
                if (lstDadosForm.Vazia() && lstDadosForm.NoFim()) return;
                CbRecCliente.Text = lstDadosForm.Valor(0);
                TxtRecNomeCliente.Text = lstDadosForm.Valor(1);
                CbRecMoeda.Text = lstDadosForm.Valor(2);
                //TxtRecCambio.Text = Convert.ToString(lstDadosForm.Valor(5));
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar o documento: {ex.Message}");
            }
        }

        /// <summary>
        /// Quando o numero da operaçao alterar carrega a grelha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRecProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            var processo = CbRecProcesso.Text;
            CarregaDadosDocumentoSelecionado(CbRecProcesso.Text);
            PopulaGrelha();
            CbRecProcesso.Text = processo;
        }

        /// <summary>
        /// Ao alterar o valor da celula faz calculos de iva e valida
        /// se sao numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRecLinhasDocumentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TxtRECTotalRetencao.Text = Convert.ToString(0, CultureInfo.InvariantCulture);
            TxtRecTotalRec.Text = Convert.ToString(0, CultureInfo.InvariantCulture);
            
            if (dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Rec."].Value == DBNull.Value)
            {
                dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Rec."].Value = 0;
            }

            if (dgvRecLinhasDocumentos.Columns[e.ColumnIndex].Name != "Valor Rec.") return;

            double valorTotRet = 0;
            double valorTotRec = 0;

            foreach (DataGridViewRow row in dgvRecLinhasDocumentos.Rows)
            {
                if (!(Convert.ToDouble(row.Cells["Valor Rec."].Value) > 0)) continue;
                var valorDoc = Convert.ToDouble(dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Doc."].Value);
                var valorRec = Convert.ToDouble(dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Rec."].Value);
                valorTotRet += Convert.ToDouble(dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Ret."].Value);
                valorTotRec += Convert.ToDouble(dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Rec."].Value);
                if (!(valorDoc < valorRec)) continue;
                PriEngine.Platform.Dialogos.MostraAviso("o valor a receber nao pode ser superior ao valor do documento.");
                valorTotRet -= Convert.ToDouble(dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Ret."].Value);
                valorTotRec -= Convert.ToDouble(dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Rec."].Value);
                dgvRecLinhasDocumentos.Rows[e.RowIndex].Cells["Valor Rec."].Value = 0;
            }

            var valorTot = valorTotRec + valorTotRet;
            TxtRECTotalRetencao.Text = Convert.ToString(valorTotRet, CultureInfo.InvariantCulture);
            TxtRecTotalRec.Text = Convert.ToString(valorTotRec, CultureInfo.InvariantCulture);
            TxtRecTotal.Text = Convert.ToString(valorTot, CultureInfo.InvariantCulture);
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
                AlteraPontosPorVirgulas();
                var documento = motores.GetCodigoDocumento(CbRecDocumento.Text);
                var existeDoc = motores.ExisteDocumento(documento, Convert.ToInt32(CbRecNumero.Text),
                    Convert.ToInt32(CbRecAno.Text));

                if (existeDoc is false)
                {
                    //Precisa calcular os totais pela soma das linhas da grelha
                    //Precisa de ir a ficha do cliente buscar varios dados
                    // dados da ficha e sabes se: IVa Cativo ou Retençao
                    var valorDoc = 0;
                    var valorRec = 0;
                    var valorPend = 0;
                    var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                    var cliente = CbRecCliente.Text;
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

                    if (validaCamposObrigatorios)
                    {
                        var id = Guid.NewGuid();
                        var cambio = motores.AlteraPontosPorVirgulas(TxtRecCambio.Text);
                        motores.CriaCabecDocumento(
                            id,
                            Convert.ToString(documento),
                            Convert.ToInt32(CbRecAno.Text),
                            Convert.ToInt32(CbRecNumero.Text),
                            Convert.ToDateTime(DateTime.Now.Date),
                            Convert.ToString(CbRecMoeda.Text),
                            Convert.ToDouble(cambio),
                            Convert.ToString(""),
                            Convert.ToString(CbRecProcesso.Text),
                            Convert.ToString(""),
                            Convert.ToString(""),
                            Convert.ToDouble(valorDoc),
                            Convert.ToDouble(0),
                            Convert.ToDouble(0),
                            Convert.ToDouble(valorPend),
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
                            dgvRecLinhasDocumentos);
                    }
                    else
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Devem preencher o campo obrigatório: Processo");
                    }
                }
                else
                {
                    //Deve simplesmente imprimir
                }

                motores.ApagaDadosForm(dgvRecLinhasDocumentos);
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
            if (CbRecDocumento.Text != "" && CbRecNumero.Text != "" && CbRecAno.Text != "")
                motores.PopulaGrelhaLinhasRecebimentos(dgvRecLinhasDocumentos, CbRecProcesso.Text);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Serve para validar se para criar X documentos os campos essenciais estao preenchidos.
        /// </summary>
        private bool ValidaCamposObrigatorios()
        {
            return CbRecProcesso.Text != "";
        }

        /// <summary>
        /// Altera virgulas por pontos
        /// </summary>
        private void AlteraPontosPorVirgulas()
        {
            var motores = new Motores();
            motores.ValidaSeTextBoxENumerica(TxtRecCambio);
        }

        private void CarregaDadosDocumentoSelecionado(string processo)
        {
            var txtQ = new StringBuilder();
            txtQ.Append("SELECT CDU_Cliente, CDU_Nome, CDU_Moeda, CDU_Cambio ");
            txtQ.Append("FROM TDU_TRT_CabecDocumentos ");
            txtQ.Append($"WHERE CDU_Processo = '{processo}' AND CDU_Documento = 'REQ' ");
            var sqlQ = txtQ.ToString();
            var lstQ = PriEngine.Engine.Consulta(sqlQ);
            if (lstQ.NoFim() && lstQ.Vazia()) return;
            CbRecCliente.Text = lstQ.Valor(0).ToString();
            TxtRecNomeCliente.Text = lstQ.Valor(1).ToString();
            CbRecMoeda.Text = lstQ.Valor(2).ToString();
            var cambio = lstQ.Valor(3);
            TxtRecCambio.Text = cambio.ToString();
        }

        #endregion

    }
}
