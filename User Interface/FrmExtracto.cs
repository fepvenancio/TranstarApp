using System;
using System.Windows.Forms;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmExtracto : Form
    {
        #region Form

        public FrmExtracto()
        {
            InitializeComponent();
        }

        public void FrmExtracto_Load(object sender, EventArgs e)
        {
            var motores = new Motores();
            motores.GetProcessos(CbExtProcessos);
            motores.GetClientes(CbExtCliente);
            ChbExtRelFechada.Checked = true;
        }

        private void CbExtCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var motores = new Motores();
            TxtExtNomeCliente.Text = motores.GetNomeCliente(CbExtCliente.Text);
            CbExtProcessos = motores.GetProcessoCliente(CbExtProcessos, CbExtCliente.Text);
        }

        private void ChbExtRelFechada_CheckedChanged(object sender, EventArgs e)
        {
            ChbExtRelMisto.Checked = !ChbExtRelFechada.Checked;
        }
        private void ChbExtRelMisto_CheckedChanged(object sender, EventArgs e)
        {
            ChbExtRelFechada.Checked = !ChbExtRelMisto.Checked;
        }

        #endregion

        private void BtnExtActualizar_Click(object sender, EventArgs e)
        {
            var dataInicial = dtpDataInicial.Value;
            var dataFinal = dtpDataFinal.Value;
            var contaFechada = ChbExtRelFechada.Checked is true;
            var motores = new Motores();
            //dgvExtDocumentos = new DataGridView();
            dgvExtDocumentos = motores.PopulaGrelhaExtDocumentos(dgvExtDocumentos, CbExtCliente.Text, CbExtProcessos.Text, contaFechada, dataInicial, dataFinal);
        }
    }
}
