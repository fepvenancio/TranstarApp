using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmRqa : Form
    {
        #region variables
        
        private readonly string _cliente;

        private readonly DateTime _data;

        private readonly double _cambio;
        
        private string Processo { get; }
        
        private string Simulacao { get; }

        #endregion

        #region form

        public FrmRqa(double cambio, DateTime data, string cliente, string processo, string simulacao)
        {
            _cambio = cambio;
            _data = data;
            _cliente = cliente;
            Processo = processo;
            Simulacao = simulacao;
            InitializeComponent();
        }

        private void FrmRQA_Load(object sender, EventArgs e)
        {
            dtpSERFRMRQAData.Value = _data.Date;
            txtSERFRMRQACambio.Text = _cambio.ToString(CultureInfo.InvariantCulture);
            txtSERFRMRQANomeCliente.Text = _cliente;
            txtSERFRMRQAProcesso.Text = Processo;
            CarregaItems();
        }

        private void BtnSERFRMREQCria_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                if (cbSERFRMRQAitem.Text != "" || txtSERFRMRQAValor.Text != @"")
                {
                    var documento = "RQA";
                    var serie = _data.Year.ToString();
                    var vendas = new IntegraPrimavera();
                    var idOrig = Guid.NewGuid();
                    var idLin = Guid.NewGuid();

                    using (var sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();

                        using (var transaction = sqlCon.BeginTransaction())
                        {
                            vendas.CriaDocumento(documento, serie, _data, Processo, Simulacao,
                                sqlCon, transaction, idOrig, idLin, cbSERFRMRQAitem.Text, Convert.ToDouble(txtSERFRMRQAValor.Text));
                            transaction.Commit();
                        }
                        
                        sqlCon.Close();
                    }
                    
                    using (var sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();

                        using (var transaction = sqlCon.BeginTransaction())
                        {
                            vendas.CriaDocumentoErp(documento, _cliente, _data, _cambio, serie,
                                Processo);
                            transaction.Commit();
                        }
                        
                        sqlCon.Close();
                        PriEngine.Platform.Dialogos.MostraAviso("Documento criado com sucesso.");
                    }
                    
                    Close();
                }
                else
                {
                    PriEngine.Platform.Dialogos.MostraAviso(
                        "O item ou o seu valor não deve ser nulo, retifique e volte a criar. ");
                }
            }
            catch
            {
                //
            }
        }
        
        #endregion

        #region metodos

        private void CarregaItems()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT CDU_Nome ");
            sql.Append("FROM [dbo].[TDU_TRT_Items] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbSERFRMRQAitem.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbSERFRMRQAitem.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }
        
        #endregion
    }
}
