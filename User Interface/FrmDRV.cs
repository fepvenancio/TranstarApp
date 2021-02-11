using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmDrv : Form
    {

        #region form

        public FrmDrv()
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
            var documento = motores.DevolveDocumento(CbRECDocumento.Text);
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
        private void FrmDrv_Load(object sender, EventArgs e)
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
        }

        private void BtnSERFRMREQCria_Click(object sender, EventArgs e)
        {
            /*
            if (chbTotal.Checked)
            {
                if (IdCab.ToString() != "")
                {
                    try
                    {
                        int i = 0;
                        foreach (DataGridViewRow dgvr in dgvLinhasDrv.Rows)
                        {
                            double total = Convert.ToDouble(dgvr.Cells[2].Value.ToString());
                            string idLinha = dgvr.Cells[3].Value.ToString();
                            //CriaLiquidacao(total, idLinha, IdCab);
                            i += 1;
                        }

                        if (Convert.ToInt32(i) > 0)
                        {
                            //CriaDocErp();
                        }
                    }
                    catch (Exception ex)
                    {
                        PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar a Liquidação: {ex.Message}");
                    }

                    LimpaGrelhaLinhasRecibo();
                    PopulaGrelhaLinhasRecibo();
                }
            }
            else
            {
                if (IdCab.ToString() != "")
                {
                    try
                    {
                        int j = 0;
                        foreach (DataGridViewRow dgvr in dgvLinhasDrv.Rows)
                        {
                            if (dgvr.Cells[0].Value.ToString() == "True")
                            {
                                j += 1;
                            }
                        }

                        Guid[] idLinhas = new Guid[j];
                        int i = 0;
                        double total = 0;
                        foreach (DataGridViewRow dgvr in dgvLinhasDrv.Rows)
                        {
                            if (dgvr.Cells[0].Value.ToString() == "True")
                            {
                                total = Convert.ToDouble(dgvr.Cells[2].Value.ToString());
                                string idLinha = dgvr.Cells[3].Value.ToString();
                                idLinhas[i] = new Guid(idLinha);
                                i += 1;
                            }
                        }
                        if (i > 0)
                        {
                            CriaLiquidacao(total, idLinhas, IdCab);
                            CriaDocErp(idLinhas);
                        }
                    }
                    catch (Exception ex)
                    {
                        PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar a Liquidação: {ex.Message}");
                    }

                    LimpaGrelhaLinhasRecibo();
                    PopulaGrelhaLinhasRecibo();
                }
            }*/
        }
        

        #endregion

        private void dgvLinhasDrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //validar se é número - Como o campo é double ele valida
            //calcular o iva e atribuir
            //coluna Escolher passa a verdadeiro
            TxtRecCriarTotalSIva.Text = "0";
            TxtRecCriarTotalIva.Text = "0";
            TxtRecCriarTotalRetencao.Text = "0";
            TxtRecCriarTotal.Text = "0";
            double totalSIva = 0;
            double iva = 0;

            foreach (DataGridViewRow row in dgvLinhasDrv.Rows)
            {
                if (row.Cells["Escolher"].Value is true)
                {
                    totalSIva += Convert.ToDouble(row.Cells["Valor"].Value);
                    iva += Convert.ToDouble(row.Cells["Valor Iva"].Value);
                }
            }

            var total = totalSIva + iva;
            TxtRecCriarTotalSIva.Text = Convert.ToString(totalSIva, CultureInfo.InvariantCulture);
            TxtRecCriarTotalIva.Text = Convert.ToString(iva, CultureInfo.InvariantCulture);
            TxtRecCriarTotalRetencao.Text = "0";
            TxtRecCriarTotal.Text = Convert.ToString(total, CultureInfo.InvariantCulture);;
        }

        private void dgvLinhasDrv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Metodos

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
                motores.PopulaGrelha(dgvLinhasDrv, motores.GetCodigoDocumento(CbRECDocumento.Text),
                    Convert.ToInt32(CbRECNumero.Text), Convert.ToInt32(CbRECAno.Text));
        }

        #endregion

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
