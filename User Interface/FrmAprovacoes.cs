using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRTv10.User_Interface
{
    public partial class FrmAprovacoes : Form
    {
        #region form

        public FrmAprovacoes()
        {
            InitializeComponent();
        }

        public void Aprovacoes_Load(object sender, EventArgs e)
        {
            ActualizaAprovacoes();
        }
        #endregion

        #region metodos/funçoes

        private void ActualizaAprovacoes()
        {
            LimpaGrelhaApr();
            PopulaGrelhaAprovacoes();
        }
        
        #endregion

        #region grelha

        private void LimpaGrelhaApr()
        {
            var dt = (DataTable) dgvAprovacoes.DataSource;
            dt?.Clear();
        }

        private void PopulaGrelhaAprovacoes()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using var sqlCon = new SqlConnection(connectionString);
            var sql = new StringBuilder();

            sql.Append("SELECT CONCAT(CDU_Documento, ' ', CDU_Numero, '/', CDU_Serie) As Documento,  ");
            sql.Append("CDU_DataDocumento As 'Data', CDU_Processo As 'Processo', CDU_Cliente As 'Cliente', CDU_Nome As 'Nome',  ");
            sql.Append("CDU_Aprovacao1 As 'Aprovacao 1', CDU_Aprovacao2 As 'Aprovacao 2', CDU_Aprovacao3 As 'Aprovacao 3', CDU_Aprovacao4 As 'Aprovacao 4' ");
            sql.Append("FROM TDU_TRT_Aprovacoes ");
            sql.Append("WHERE CDU_Aprovacao4 = 0 ");

            var query = sql.ToString();
            sqlCon.Open();
            var sqlDa = new SqlDataAdapter(query, sqlCon);
            var dataTable = new DataTable();
            sqlDa.Fill(dataTable);
            dgvAprovacoes.DataSource = dataTable;
            dgvAprovacoes.Columns[0].Width = 150;
            dgvAprovacoes.Columns[1].Width = 100;
            dgvAprovacoes.Columns[2].Width = 100;
            dgvAprovacoes.Columns[3].Width = 100;
            dgvAprovacoes.Columns[4].Width = 300;
            dgvAprovacoes.Columns[5].Width = 150;
            dgvAprovacoes.Columns[6].Width = 150;
            dgvAprovacoes.Columns[7].Width = 150;
            dgvAprovacoes.Columns[8].Width = 150;
            dgvAprovacoes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            dgvAprovacoes.DefaultCellStyle.Font = new Font("Arial", 10);
            sqlCon.Close();
        }
        
        #endregion
    }
}
