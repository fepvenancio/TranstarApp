using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TRTv10.User_Interface
{
    public partial class FrmTransporte : Form
    {
        public string StrProcesso;

        public FrmTransporte(string processo)
        {
            StrProcesso = processo;
            InitializeComponent();
        }

        private void ChbSERFRMSubCT_Alterada(object sender, EventArgs e)
        {
            if (chbSERFRMInt.Checked) chbSERFRMInt.Checked = false;
            
            if (chbSERFRMSubCT.Checked)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using SqlConnection sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                using (var transaction = sqlCon.BeginTransaction())
                {
                    var sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaItemsServTipoTransporte", sqlCon)
                    {
                        Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                    };
                    sqlCmdLin.Parameters.AddWithValue("@Processo", StrProcesso);
                    sqlCmdLin.Parameters.AddWithValue("@TipoTrans", "SUB");
                    sqlCmdLin.ExecuteNonQuery();

                    transaction.Commit();
                }
                sqlCon.Close();
            }
        }

        private void ChbSERFRMInt_Alterada(object sender, EventArgs e)
        {
            if (chbSERFRMSubCT.Checked) chbSERFRMSubCT.Checked = false;

            if (chbSERFRMInt.Checked)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using SqlConnection sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                using (var transaction = sqlCon.BeginTransaction())
                {
                    var sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaItemsServTipoTransporte", sqlCon)
                    {
                        Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                    };
                    sqlCmdLin.Parameters.AddWithValue("@Processo", StrProcesso);
                    sqlCmdLin.Parameters.AddWithValue("@TipoTrans", "INT");
                    sqlCmdLin.ExecuteNonQuery();

                    transaction.Commit();
                }
                sqlCon.Close();
            }
        }

        private void FrmTransporte_Load(object sender, EventArgs e)
        {

        }
    }
}
