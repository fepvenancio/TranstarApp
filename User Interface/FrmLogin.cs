using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;

namespace TRTv10.User_Interface
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

         #region "Form Events"

        private void BtnLOGEntrar_Click(object sender, EventArgs e)
        {
            bool loginFeito = false;
            try
            {
                if (txtLOGPassword != null)
                {
                    PriEngine.CreatContext("TRT10", txtLOGUtilizador.Text, txtLOGPassword.Text);

                    if (PriEngine.EngineStatus)
                    {
                        var status = new StringBuilder();

                        status.Append("Company: " + PriEngine.Platform.Contexto.Empresa.CodEmp + " | ");
                        status.Append("Comp any Name: " + PriEngine.Platform.Contexto.Empresa.IDNome + " | ");
                        status.Append("Currency: " + PriEngine.Platform.Contexto.Empresa.MoedaBase);

                        lblStatus.Text = status.ToString();
                        lblLOGSucesso.ForeColor = Color.Chartreuse;
                        lblLOGSucesso.Text = @"Login efectuado com sucesso";

                        Hide();
                        var frmExplorer = new FrmExplorer(txtLOGUtilizador.Text);
                        loginFeito = true;
                        frmExplorer.ShowDialog();
                        frmExplorer.Close();
                        PriEngine.Engine.FechaEmpresaTrabalho();
                        Close();
                    }
                    else
                    {
                        lblStatus.Text = @"Não é possivel aceder ao programa, contacte o administrador de sistemas.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblLOGSucesso.ForeColor = Color.Red;
                lblLOGSucesso.Text = @"Login não existe ou errado.";

                if (ex.Message != null)
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loginFeito is true)
                    Close();
            }
        }

        private void TxtLOGUtilizador_TextChanged(object sender, EventArgs e)
        {
        }

        private void TimerLOGLogin_Tick(object sender, EventArgs e)
        {
        }

        private void TxtLOGPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BtnLOGEntrar_Click(this, new EventArgs());
        }

        #endregion
    }
}
