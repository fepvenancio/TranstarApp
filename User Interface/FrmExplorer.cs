using System;
using System.Windows.Forms;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmExplorer : Form
    {
        private FrmCotacao _frmCotacao;
        private FrmRequisicoes _frmRequisicoes;
        private FrmAprovacoes _frmAprovacoes;
        private FrmDocumento _frmDocumento;
        private FrmDrv _frmDrv;
        private FrmExtracto _frmExtracto;
        private FrmRi _frmRi;
        private FrmOutrosDocs _frmOutrosDocs;

        public FrmExplorer(string user)
        {
            InitializeComponent();
            tlsLabelUtilizador.Text = user;
        }

        private void FrmExplorer_Load(object sender, EventArgs e)
        {
            
        }

        private void CriarCotacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmCotacao = new FrmCotacao();
            _frmCotacao.Show();
        }

        private void ExtractoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmExtracto = new FrmExtracto();
            _frmExtracto.Show();
        }

        private void aprovaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmAprovacoes = new FrmAprovacoes();
            _frmAprovacoes.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void requisiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmRequisicoes = new FrmRequisicoes();
            _frmRequisicoes.Show();
        }

        private void reimpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmDocumento = new FrmDocumento();
            _frmDocumento.DesabilitaBtnConverter(true);
            _frmDocumento.Show();
        }

        private void conversãoDeCOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmDocumento = new FrmDocumento();
            _frmDocumento.DesabilitaBtnConverter(false);
            _frmDocumento.Show();
        }

        private void drv_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmDrv = new FrmDrv();
            _frmDrv.Show();
        }

        private void requisiçõesInternasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmRi = new FrmRi();
            _frmRi.Show();
        }

        private void documentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmOutrosDocs = new FrmOutrosDocs();
            _frmOutrosDocs.Show();
        }
    }
}
