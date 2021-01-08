using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;

namespace TRTv10.User_Interface
{
    public partial class FrmMovBancario : Form
    {
        #region Variaveis
        public string ContaBancaria { get; set; }

        public string Movimento { get; set; }

        public string Descricao { get; set; }

        #endregion

        #region Metodos

        public void ErpContasBancarias()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Conta ");
            sql.Append("FROM [dbo].[ContasBancarias] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbMOVConta.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbMOVConta.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }

        public void ErpMovBancarios()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Movim ");
            sql.Append("FROM [dbo].[DocumentosBancos] ");
            sql.Append("WHERE TipoMv = 'C' AND TipoCX = 1 OR TipoMv = 'C' AND TipoDO = 1 ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbMOVmovimento.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbMOVmovimento.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }
        #endregion

        #region Form

        public FrmMovBancario()
        {
            InitializeComponent();
        }

        #endregion
    }
}
