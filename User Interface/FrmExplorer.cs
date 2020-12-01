using System;
using System.Windows.Forms;

namespace TRTv10.User_Interface
{
    public partial class FrmExplorer : Form
    {
        private FrmServicos _frmServicos;
        private FrmProcesso _frmProcesso;
        private FrmAprovacoes _frmAprovacoes;

        public FrmExplorer(string user)
        {
            InitializeComponent();
            tlsLabelUtilizador.Text = user;
        }

        private void FrmExplorer_Load(object sender, EventArgs e)
        {
            _frmServicos ??= new FrmServicos();
            _frmProcesso ??= new FrmProcesso();
            _frmAprovacoes ??= new FrmAprovacoes();

            _frmServicos.ActualizaDadosSimulacao();
            _frmServicos.ActualizaDadosServ();
            _frmServicos.ActualizaDadosClientes();
            _frmServicos.ActualizaDadosMoedas();
            _frmServicos.NumeroSimulacao();
            _frmServicos.dataGridViewSER.Columns[0].Width = 300;
            _frmServicos.dataGridViewSER.Columns[1].Width = 100;
            _frmServicos.dataGridViewSER.Columns[2].Width = 150;
            _frmServicos.dataGridViewSER.Columns[3].Width = 150;
        }

        private void CriarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmServicos.ShowDialog();
        }

        private void ConsultaDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmProcesso.ShowDialog();
        }

        private void aprovaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmAprovacoes.ShowDialog();
        }
    }
}
