using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using StdBE100;
using StdPlatBS100;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmServicos : Form
    {
        #region variaveis

        private int _numSimulacao;
        private bool _camposValidados;
        #endregion

        #region Metodos de Inicializaçao

        /// <summary>
        ///     Vai ao ERP ler os clientes existentes e carrega o codigo dos
        ///     mesmos na combobox
        /// </summary>
        public void ActualizaDadosClientes()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Cliente ");
            sql.Append("FROM [dbo].[Clientes] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbSEREntidade.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbSEREntidade.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }

        /// <summary>
        ///     Vai ao ERP ler as moedas existentes e carrega o codigo das
        ///     mesmas na combobox
        /// </summary>
        public void ActualizaDadosMoedas()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Moeda ");
            sql.Append("FROM [dbo].[Moedas] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbSERMoeda.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbSERMoeda.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }

        /// <summary>
        ///     Se houver cliente selecionado vai buscar os codigos de simulação existentes
        ///     desse cliente, caso contrario, vai buscar todos os numeros de simulaçao.
        /// </summary>
        public void ActualizaDadosSimulacao()
        {
            var sql = new StringBuilder();

            if (cbSEREntidade.Text == "")
            {
                sql.Append("SELECT CDU_Nome ");
                sql.Append("FROM [dbo].[TDU_TRT_Simulacao] ");
            }
            else
            {
                sql.Append("SELECT CDU_Nome ");
                sql.Append("FROM [dbo].[TDU_TRT_Simulacao] ");
                sql.Append("WHERE CDU_Cliente = '" + cbSEREntidade.Text + "' ");
            }

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbSERNumSimulacao.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbSERNumSimulacao.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }

        /// <summary>
        ///     Carrega o codigo dos Tipos de Serviços na combobox da tabela TiposServico
        /// </summary>
        public void ActualizaDadosServ()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT CDU_Nome ");
            sql.Append("FROM [dbo].[TDU_TRT_TiposServico] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbSERCod.Items.Clear();

                while (!lstPesquisa.NoFim())
                {
                    cbSERCod.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
            else
            {
                PriEngine.Platform.Dialogos.MostraAviso(@"Não existem artigos criados na base de dados.");
            }
        }

        /// <summary>
        ///     Carrega a combobox com os numeros de simulação o prefixo COT e adicionado
        ///     por codigo.
        /// </summary>
        public void NumeroSimulacao()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Max(Convert(int, CDU_Codigo)) ");
            sql.Append("FROM [dbo].[TDU_TRT_Simulacao] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia() || lstPesquisa.Valor(0).ToString() == "")
            {
                cbSERNumSimulacao.Text = @"COT1";
            }
            else
            {
                int numSimulacao = Convert.ToInt32(lstPesquisa.Valor(0)) + 1;
                cbSERNumSimulacao.Text = @"COT" + numSimulacao;
            }
        }

        /// <summary>
        /// Preenche os valores da combobox cbSERAviaoNavio
        /// </summary>
        public void ActualizaDadosTransporte()
        {
            cbSERAviaoNavio.Items.Add("Avião");
            cbSERAviaoNavio.Items.Add("Rodoviário");
            cbSERAviaoNavio.Items.Add("Marítimo");
        }

        #endregion

        #region Metodos de Criaçao / Update

        /// <summary>
        /// Serve para validar se para criar X documentos os campos essenciais estao preenchidos.
        /// </summary>
        private void ValidaCamposObrigatorios()
        {
            _camposValidados = false || cbSERMoeda.Text != "" && txtSERVCIF.Text != "" && txtSERVAduaneiro.Text != "" &&
                txtSERCambio.Text != "" && txtSERTipoMercadoria.Text != "";
        }


        /// <summary>
        ///     Carrega os valores da ComboBox Operaçao
        /// </summary>
        private void ActualizaOperacoes()
        {
            cbSEROperacao.Items.Clear();

            if (cbSERCod.Text == @"Despacho / Desalfandegamento")
            {
                cbSEROperacao.Items.Add("Cotação");
                cbSEROperacao.Items.Add("Requisição de fundos");
            }
            else if (cbSERCod.Text == @"Licenciamento Fact/DUP")
            {
                cbSEROperacao.Items.Add("Cotação");
                cbSEROperacao.Items.Add("Requisição de fundos");
                cbSEROperacao.Items.Add("Factura de Serviços");
            }
            else if (cbSERCod.Text == @"Outros Serviços")
            {
                cbSEROperacao.Items.Add("Cotação");
                cbSEROperacao.Items.Add("Factura de Serviços");
            }
            else
            {
                cbSEROperacao.Items.Add("Cotação");
                cbSEROperacao.Items.Add("Requisição de fundos");
                cbSEROperacao.Items.Add("Factura de Serviços");
            }
        }

        /// <summary>
        ///     Apaga os registos da tabela Simulação e Items Serviços
        /// </summary>
        private void AnulaSimulacao()
        {
            var lstExiste = PriEngine.Engine.Consulta(
                $"SELECT CDU_Nome FROM TDU_TRT_Simulacao WHERE CDU_Nome = '{cbSERNumSimulacao.Text}'");

            if (!lstExiste.Vazia())
            {
                var sqlDel = new StringBuilder();

                sqlDel.Append($"DELETE FROM TDU_TRT_Simulacao WHERE CDU_Nome = '{cbSERNumSimulacao.Text}' ");
                sqlDel.Append($"DELETE FROM TDU_TRT_ItemsServicos WHERE CDU_Processo = '{cbSERNumSimulacao.Text}' ");

                var query = sqlDel.ToString();
                var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }

                //PriEngine.Engine.DSO.ExecuteSQL(query);

                ActualizaDadosSimulacao();
                NumeroSimulacao();
                LimpaGrelha();
            }
            else
            {
                PriEngine.Platform.Dialogos.MostraAviso("A cotação que pretende apagar não existe.");
            }
        }

        /// <summary>
        ///     Valida qual o numero da ultima simulação criada, adiciona 1 e cria na BD tabela Simulaçao a mesma
        /// </summary>
        private void CriaSimulacao()
        {
            if (cbSERNumSimulacao.Text != "")
            {
                int numSimulacao;
                DateTime data = dtpSERDataDU.Value;
                DateTime dataChegada = dtpSERDataDU.Value;
                DateTime dataEntrada= dtpSERDataDU.Value;
                DateTime dataSaida = dtpSERDataDU.Value;
                DateTime dataDu = dtpSERDataDU.Value;

                var strSimulacao = $"SELECT Max(Convert(int, CDU_Codigo)) FROM TDU_TRT_Simulacao";
                var lstSimulacao = PriEngine.Engine.Consulta(strSimulacao);

                if (lstSimulacao.Vazia() || lstSimulacao.Valor(0).ToString() == "")
                    _numSimulacao = 1;
                else
                    _numSimulacao = Convert.ToInt32(lstSimulacao.Valor(0)) + 1;

                var nomeSimulacao = "COT" + _numSimulacao;
                numSimulacao = Convert.ToInt32(_numSimulacao);

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                
                using (var sqlCon = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_InsereSimulacao", sqlCon);
                    sqlCmdLin.CommandType = CommandType.StoredProcedure;
                    sqlCmdLin.Parameters.AddWithValue("@numSimulacao", numSimulacao);
                    sqlCmdLin.Parameters.AddWithValue("@nomeSimulacao", nomeSimulacao);
                    sqlCmdLin.Parameters.AddWithValue("@Cliente", cbSEREntidade.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Moeda", cbSERMoeda.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Referencia", txtSERReferencia.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorCIF", txtSERVCIF.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorAduaneiro", txtSERVAduaneiro.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Cambio", txtSERCambio.Text);
                    sqlCmdLin.Parameters.AddWithValue("@BLCartaPorte", txtSERBLCartaPorte.Text);
                    sqlCmdLin.Parameters.AddWithValue("@NumVolumes", txtSERNumVolumes.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Peso", txtSERPeso.Text);
                    sqlCmdLin.Parameters.AddWithValue("@AviaoNavio", cbSERAviaoNavio.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Manifesto", txtSERManifesto.Text);
                    sqlCmdLin.Parameters.AddWithValue("@NumDAR", txtSERNumDAR.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorDAR", txtSERValorDAR.Text);
                    sqlCmdLin.Parameters.AddWithValue("@DU", txtSERDU.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Data", data.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataChegada", dataChegada.ToString("MM/dd/yyyy")); 
                    sqlCmdLin.Parameters.AddWithValue("@DataEntrada", dataEntrada.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataSaida", dataSaida.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataDU", dataDu.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DUP", txtSERDUP.Text);
                    sqlCmdLin.Parameters.AddWithValue("@CNCA", txtSERCNCA.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Operacao", cbSEROperacao.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Obs", txtSERObs.Text);
                    sqlCmdLin.Parameters.AddWithValue("@TipoMercadoria", txtSERTipoMercadoria.Text);
                    sqlCmdLin.Parameters.AddWithValue("@RUP", txtSERRUP.Text);

                    sqlCon.Open();
                    sqlCmdLin.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
        }

        /// <summary>
        ///     Faz update a tabela Simulação, isto e utilizado em Cotaçoes caso queiram alterar algo.
        /// </summary>
        private void UpdateSimulacao()
        {
            DateTime data = dtpSERDataDU.Value;
            DateTime dataChegada = dtpSERDataDU.Value;
            DateTime dataEntrada= dtpSERDataDU.Value;
            DateTime dataSaida = dtpSERDataDU.Value;
            DateTime dataDu = dtpSERDataDU.Value;
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            using (var transaction = sqlCon.BeginTransaction())
            {
                var sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaSimulacao", sqlCon)
                {
                    Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@nomeSimulacao", cbSERNumSimulacao.Text);
                sqlCmdLin.Parameters.AddWithValue("@Cliente", cbSEREntidade.Text);
                sqlCmdLin.Parameters.AddWithValue("@Moeda", cbSERMoeda.Text);
                sqlCmdLin.Parameters.AddWithValue("@Referencia", txtSERReferencia.Text);
                sqlCmdLin.Parameters.AddWithValue("@ValorCIF", txtSERVCIF.Text);
                sqlCmdLin.Parameters.AddWithValue("@ValorAduaneiro", txtSERVAduaneiro.Text);
                sqlCmdLin.Parameters.AddWithValue("@Cambio", txtSERCambio.Text);
                sqlCmdLin.Parameters.AddWithValue("@BLCartaPorte", txtSERBLCartaPorte.Text);
                sqlCmdLin.Parameters.AddWithValue("@NumVolumes", txtSERNumVolumes.Text);
                sqlCmdLin.Parameters.AddWithValue("@Peso", txtSERPeso.Text);
                sqlCmdLin.Parameters.AddWithValue("@AviaoNavio", cbSERAviaoNavio.Text);
                sqlCmdLin.Parameters.AddWithValue("@Manifesto", txtSERManifesto.Text);
                sqlCmdLin.Parameters.AddWithValue("@NumDAR", txtSERNumDAR.Text);
                sqlCmdLin.Parameters.AddWithValue("@ValorDAR", txtSERValorDAR.Text);
                sqlCmdLin.Parameters.AddWithValue("@DU", txtSERDU.Text);
                sqlCmdLin.Parameters.AddWithValue("@Data", data.ToString("MM/dd/yyyy"));
                sqlCmdLin.Parameters.AddWithValue("@DataChegada", dataChegada.ToString("MM/dd/yyyy")); 
                sqlCmdLin.Parameters.AddWithValue("@DataEntrada", dataEntrada.ToString("MM/dd/yyyy"));
                sqlCmdLin.Parameters.AddWithValue("@DataSaida", dataSaida.ToString("MM/dd/yyyy"));
                sqlCmdLin.Parameters.AddWithValue("@DataDU", dataDu.ToString("MM/dd/yyyy"));
                sqlCmdLin.Parameters.AddWithValue("@DUP", txtSERDUP.Text);
                sqlCmdLin.Parameters.AddWithValue("@CNCA", txtSERCNCA.Text);
                sqlCmdLin.Parameters.AddWithValue("@Operacao", cbSEROperacao.Text);
                sqlCmdLin.Parameters.AddWithValue("@Obs", txtSERObs.Text);
                sqlCmdLin.Parameters.AddWithValue("@TipoMercadoria", txtSERTipoMercadoria.Text);
                sqlCmdLin.Parameters.AddWithValue("@RUP", txtSERRUP.Text);
                sqlCmdLin.ExecuteNonQuery();

                transaction.Commit();
            }
            sqlCon.Close();
        }

        /// <summary>
        ///     Cria o registo na tabela ItemsServiços
        /// </summary>
        private void CriaServicos()
        {
            var tipoServ = string.Empty;

            var strTipoServ = $"SELECT CDU_Codigo FROM TDU_TRT_TiposServico WHERE CDU_Nome = '{cbSERCod.Text}'";
            var lstTipoServ = PriEngine.Engine.Consulta(strTipoServ);

            if (!lstTipoServ.Vazia()) tipoServ = "%" + lstTipoServ.Valor(0) + "%";
            
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            using (var transaction = sqlCon.BeginTransaction())
            {
                var sqlCmdLin = new SqlCommand("TDU_TRT_InsereItemsServicos", sqlCon)
                {
                    Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@TipoServ", lstTipoServ.Valor(0));
                sqlCmdLin.Parameters.AddWithValue("@Operacao", cbSEROperacao.Text);
                sqlCmdLin.Parameters.AddWithValue("@Processo", cbSERNumSimulacao.Text);
                sqlCmdLin.Parameters.AddWithValue("@TipoServL", tipoServ);

                sqlCmdLin.ExecuteNonQuery();
                transaction.Commit();
                sqlCon.Close();
            }
        }

        /// <summary>
        ///     Ao escolherem um numero de simulaçao ele carrega os dados do SQL para a Form
        /// </summary>
        private void CarregaServicos()
        {
            var sql = new StringBuilder();

            sql.Append("SELECT TOP(1) S.CDU_Nome, I.CDU_Operacao, U.CDU_Cliente, U.CDU_Data, U.CDU_Cambio ");
            sql.Append(", U.CDU_Moeda, U.CDU_Referencia, U.CDU_ValorCIF ");
            sql.Append(", U.CDU_ValorAduaneiro, U.CDU_BLCartaPorte, U.CDU_NumVolumes, U.CDU_Peso ");
            sql.Append(", U.CDU_AviaoNavio, U.CDU_Manifesto, U.CDU_NumDAR, U.CDU_ValorDAR ");
            sql.Append(", U.CDU_DU, U.CDU_DataChegada, U.CDU_DataEntrada, U.CDU_DataSaida ");
            sql.Append(", U.CDU_DataDU, U.CDU_DUP, U.CDU_CNCA, U.CDU_Obs, U.CDU_RUP, C.Nome, U.CDU_TipoMercadoria ");
            sql.Append(", P.CDU_Codigo ");
            sql.Append("FROM TDU_TRT_ItemsServicos I ");
            sql.Append("INNER JOIN TDU_TRT_TiposServico S  ");
            sql.Append("ON I.CDU_TipoServ = S.CDU_Codigo ");
            sql.Append("INNER JOIN TDU_TRT_Simulacao U ");
            sql.Append("ON U.CDU_Nome = I.CDU_Processo ");
            sql.Append("INNER JOIN TDU_TRT_Items T ");
            sql.Append("ON T.CDU_Nome = I.CDU_Items ");
            sql.Append("INNER JOIN Clientes C ");
            sql.Append("ON C.Cliente = U.CDU_Cliente ");
            sql.Append("LEFT JOIN TDU_TRT_Processo P ");
            sql.Append("ON P.CDU_NumSimulacao = I.CDU_Processo ");
            sql.Append("WHERE I.CDU_Processo = '" + cbSERNumSimulacao.Text + "' ");
            sql.Append("ORDER By T.CDU_Posicao");

            var query = sql.ToString();

            StdBELista lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
                cbSERCod.Text = lstPesquisa.Valor(0).ToString();
                cbSEROperacao.Text = lstPesquisa.Valor(1).ToString();
                cbSEREntidade.Text = lstPesquisa.Valor(2).ToString();
                dtpSERData.Text = lstPesquisa.Valor(3).ToString();
                txtSERCambio.Text = lstPesquisa.Valor(4).ToString();
                cbSERMoeda.Text = lstPesquisa.Valor(5).ToString();
                txtSERReferencia.Text = lstPesquisa.Valor(6).ToString();
                txtSERVCIF.Text = lstPesquisa.Valor(7).ToString();
                txtSERVAduaneiro.Text = lstPesquisa.Valor(8).ToString();
                txtSERBLCartaPorte.Text = lstPesquisa.Valor(9).ToString();
                txtSERNumVolumes.Text = lstPesquisa.Valor(10).ToString();
                txtSERPeso.Text = lstPesquisa.Valor(11).ToString();
                cbSERAviaoNavio.Text = lstPesquisa.Valor(12).ToString();
                txtSERManifesto.Text = lstPesquisa.Valor(13).ToString();
                txtSERNumDAR.Text = lstPesquisa.Valor(14).ToString();
                txtSERValorDAR.Text = lstPesquisa.Valor(15).ToString();
                txtSERDU.Text = lstPesquisa.Valor(16).ToString();
                dtpSERDataChegada.Text = lstPesquisa.Valor(17).ToString();
                dtpSERDataEntrada.Text = lstPesquisa.Valor(18).ToString();
                dtpSERDataSaida.Text = lstPesquisa.Valor(19).ToString();
                dtpSERDataDU.Text = lstPesquisa.Valor(20).ToString();
                txtSERDUP.Text = lstPesquisa.Valor(21).ToString();
                txtSERCNCA.Text = lstPesquisa.Valor(22).ToString();
                txtSERObs.Text = lstPesquisa.Valor(23).ToString();
                txtSERRUP.Text = lstPesquisa.Valor(24).ToString();
                txtSERNomeCliente.Text = lstPesquisa.Valor(25).ToString();
                txtSERTipoMercadoria.Text = lstPesquisa.Valor(26).ToString();
                txtSERProcesso.Text  = lstPesquisa.Valor(27).ToString();
            }
            else
            {
                LimpaServicos();
            }
        }

        /// <summary>
        ///     Limpa todos os valores da Form
        /// </summary>
        private void LimpaServicos()
        {
            cbSERCod.Text = "";
            cbSEROperacao.Text = "";
            cbSEREntidade.Text = "";
            dtpSERData.Text = "";
            txtSERCambio.Text = "";
            cbSERMoeda.Text = "";
            txtSERReferencia.Text = "";
            txtSERVCIF.Text = "";
            txtSERVAduaneiro.Text = "";
            txtSERBLCartaPorte.Text = "";
            txtSERNumVolumes.Text = "";
            txtSERPeso.Text = "";
            cbSERAviaoNavio.Text = "";
            txtSERManifesto.Text = "";
            txtSERNumDAR.Text = "";
            txtSERValorDAR.Text = "";
            txtSERDU.Text = "";
            dtpSERDataChegada.Text = "";
            dtpSERDataEntrada.Text = "";
            dtpSERDataSaida.Text = "";
            dtpSERDataDU.Text = "";
            txtSERDUP.Text = "";
            txtSERCNCA.Text = "";
            txtSERObs.Text = "";
            txtSERRUP.Text = "";
            txtSERNomeCliente.Text = "";
            txtSERTipoMercadoria.Text = "";
            txtSERRequisicao.Text = "";
            txtSERProcesso.Text = "";
            txtSERValidaData.Text = "";

            ActualizaDadosSimulacao();
            NumeroSimulacao();
            LimpaGrelha();
        }

        /// <summary>
        ///     Imprime o mapa da Simulação
        /// </summary>
        /// <param name="simulacao"></param>
        private void ImprimeSimulacao()
        {
            ValidaCamposObrigatorios();

            if (_camposValidados is true)
            {
                int numerador = 0;
                string codProcesso;
                string fileName = "";
     
                if (cbSEROperacao.Text == @"Cotação" && cbSERNumSimulacao.Text != "")
                {
                    codProcesso = cbSERNumSimulacao.Text;
                    PriEngine.Platform.Mapas.Inicializar("BAS");
                    PriEngine.Platform.Mapas.Destino = StdBSTipos.CRPEExportDestino.edFicheiro;
                    var list = Directory.GetFiles(@"\\192.168.10.10\primavera\SG100\Mapas\App", "*.pdf");
                    numerador = list.Length + 1;
                    fileName = string.Format("{0}_{1}.pdf", codProcesso, numerador);
                    PriEngine.Platform.Mapas.SetFileProp(StdBSTipos.CRPEExportFormat.efPdf, @$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
                    PriEngine.Platform.Mapas.JanelaPrincipal = 0;
                    PriEngine.Platform.Mapas.SelectionFormula = $"{{TDU_TRT_ItemsServicos.CDU_Processo}} = '{codProcesso}'";
                    PriEngine.Platform.Mapas.ImprimeListagem("TRT_SIM", "Simulação de Custos");
                    System.Diagnostics.Process.Start(@$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
                }
                if (cbSEROperacao.Text == @"Requisição de fundos")
                {
                    codProcesso = cbSERNumSimulacao.Text; //alterar para REQ
                    PriEngine.Platform.Mapas.Inicializar("BAS");
                    PriEngine.Platform.Mapas.Destino = StdBSTipos.CRPEExportDestino.edFicheiro;
                    var list = Directory.GetFiles(@"\\192.168.10.10\primavera\SG100\Mapas\App", "*.pdf");
                    numerador = list.Length + 1;
                    fileName = $"{codProcesso}_{numerador}.pdf";
                    PriEngine.Platform.Mapas.SetFileProp(StdBSTipos.CRPEExportFormat.efPdf, @$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
                    PriEngine.Platform.Mapas.JanelaPrincipal = 0;
                    PriEngine.Platform.Mapas.SelectionFormula = $"{{TDU_TRT_ItemsServicos.CDU_Processo}} = '{codProcesso}'";
                    PriEngine.Platform.Mapas.ImprimeListagem("TRT_SIM", "Simulação de Custos");
                    System.Diagnostics.Process.Start(@$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
                }

                if (cbSEROperacao.Text == @"Factura de Serviços" && cbSERNumSimulacao.Text != "")
                {
                    bool valida = false;
                    var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    //Validar se a FS ja existe
                    string sqlDocExiste = $"SELECT Tipodoc, NumDoc, Serie FROM CabecDoc WHERE TipoDoc = 'FS' AND Requisicao = '{cbSERNumSimulacao.Text}'";
                    StdBELista lstDocExiste = PriEngine.Engine.Consulta(sqlDocExiste);

                    if (lstDocExiste.Vazia())
                    {
                        if (cbSEREntidade.Text != "" || cbSEREntidade.Text != @"VD")
                        {
                            var documento = "FS";
                            var processoFS = cbSERNumSimulacao.Text;
                            var serie = DateTime.Now.Year.ToString();
                            var vendas = new IntegraPrimavera();
                            var idOrig = Guid.NewGuid();
                            var idLin = Guid.NewGuid();

                            using (var sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();

                                using (var transaction = sqlCon.BeginTransaction())
                                {
                                    vendas.CriaProcesso(processoFS, processoFS, sqlCon, transaction);
                                    vendas.CriaDocumento(documento, serie, DateTime.Now, processoFS, processoFS,
                                        sqlCon, transaction, idOrig, idLin, "", 0);
                                    transaction.Commit();
                                }

                                sqlCon.Close();
                            }

                            using (var sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();

                                using var transaction = sqlCon.BeginTransaction();
                                vendas.CriaDocumentoErp(documento, cbSEREntidade.Text, DateTime.Now, Convert.ToDouble(txtSERCambio.Text), serie,
                                    processoFS);
                                transaction.Commit();
                            }

                            PriEngine.Platform.Dialogos.MostraAviso("Documento criado com sucesso.");
                            Close();
                        }
                        else
                        {
                            PriEngine.Platform.Dialogos.MostraAviso(
                                "O cliente não deve ser nulo ou VD, altere o cliente por favor. ");
                        }

                    }

                    codProcesso = cbSERNumSimulacao.Text; //alterar para FS
                    PriEngine.Platform.Mapas.Inicializar("BAS");
                    PriEngine.Platform.Mapas.Destino = StdBSTipos.CRPEExportDestino.edFicheiro;
                    var list = Directory.GetFiles(@"\\192.168.10.10\primavera\SG100\Mapas\App", "*.pdf");
                    numerador = list.Length + 1;
                    fileName = $"{codProcesso}_{numerador}.pdf";
                    PriEngine.Platform.Mapas.SetFileProp(StdBSTipos.CRPEExportFormat.efPdf, @$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
                    PriEngine.Platform.Mapas.JanelaPrincipal = 0;
                    PriEngine.Platform.Mapas.SelectionFormula = $"{{TDU_TRT_ItemsServicos.CDU_Processo}} = '{codProcesso}'";
                    PriEngine.Platform.Mapas.ImprimeListagem("TRT_SIM", "Simulação de Custos");
                    System.Diagnostics.Process.Start(@$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
                }
            }
            else
            {
                PriEngine.Platform.Dialogos.MostraAviso("Devem preencher os campos obrigatorios: Moeda, Valor CIF, Valor Aduaneiro, " +
                                                        "Câmbio, Tipo de Mercadoria e Data de Entrada ");
            }
        }
        
        /// <summary>
        ///     Baseado no cliente escolhido le o ERP e vai Buscar o nome do Cliente para preencher
        ///     no campo do Nome.
        /// </summary>
        private void NomeCliente()
        {
            var cliente = cbSEREntidade.Text;

            if (cliente != "") txtSERNomeCliente.Text = PriEngine.Engine.Base.Clientes.DaNome(cliente);
        }

        #endregion

        #region Grelha

        /// <summary>
        ///     Limpa os valores da grelha
        /// </summary>
        private void LimpaGrelha()
        {
            var dt = (DataTable) dataGridViewSER.DataSource;
            if (dt != null)
                dt.Clear();
        }

        /// <summary>
        ///     Carrega os valores da Tabela Items Serviços para a grelha
        /// </summary>
        /// <param name="processo"></param>
        private void PopulaGrelha(string processo)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"]
                    .ConnectionString;

                using var sqlCon = new SqlConnection(connectionString);
                var sql = new StringBuilder();

                if (cbSERNumSimulacao.Text != "")
                {
                    sql.Append("SELECT S.CDU_Items, S.CDU_ValoresSimulacao, S.CDU_IVASimulacao ");
                    sql.Append(", S.CDU_Processo, S.CDU_Descricao, S.CDU_Data ");
                    sql.Append("FROM TDU_TRT_ItemsServicos S ");
                    sql.Append("INNER JOIN TDU_TRT_Items I ");
                    sql.Append("ON S.CDU_Items = I.CDU_Nome ");
                    sql.Append("WHERE CDU_Processo = '" + processo + "' ");
                    sql.Append("ORDER BY I.CDU_Posicao ");
                }
                else
                {
                    sql.Append("SELECT S.CDU_Items, S.CDU_ValoresSimulacao, S.CDU_IVASimulacao ");
                    sql.Append(", S.CDU_Processo, S.CDU_Descricao, S.CDU_Data ");
                    sql.Append("FROM TDU_TRT_ItemsServicos S ");
                    sql.Append("INNER JOIN TDU_TRT_Items I ");
                    sql.Append("ON S.CDU_Items = I.CDU_Nome ");
                    sql.Append("WHERE CDU_Processo = '0' ");
                    sql.Append("ORDER BY I.CDU_Posicao ");
                }

                var query = sql.ToString();

                sqlCon.Open();
                var sqlDa = new SqlDataAdapter(query, sqlCon);
                var dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridViewSER.DataSource = dtbl;
                dataGridViewSER.Columns[0].Width = 300;
                dataGridViewSER.Columns[1].Width = 100;
                dataGridViewSER.Columns[2].Width = 100;
                dataGridViewSER.Columns[3].Width = 100;
                dataGridViewSER.Columns[4].Width = 200;
                dataGridViewSER.Columns[5].Width = 150;
            }
            catch
            {
                //Evita erro ao inicializar
            }
        }

        /// <summary>
        ///     Caso nao exista requisaçao ele permite alterar os valores nas linhas da grelha.
        /// </summary>
        private void GravaDadosGrelha()
        {
            if (txtSERRequisicao.Text == "")
                try
                {
                    var connectionString = ConfigurationManager.ConnectionStrings[name: "ConnectionString"].ConnectionString;

                    if (dataGridViewSER.CurrentRow == null) return;
                    using var sqlCon = new SqlConnection(connectionString: connectionString);
                    sqlCon.Open();
                    var dgvRow = dataGridViewSER.CurrentRow;
                    var sqlCmd = new SqlCommand(cmdText: "STP_TRT_GrelhaSER_Edit", connection: sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Processo",
                        value: dgvRow.Cells[columnName: "txtProcesso"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "txtProcesso"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Item",
                        value: dgvRow.Cells[columnName: "txtItem"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "txtItem"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue(parameterName: "@ValorSim",
                        value: Convert.ToDouble(
                            value: dgvRow.Cells[columnName: "txtValoresSimulacao"].Value == DBNull.Value
                                ? 0
                                : dgvRow.Cells[columnName: "txtValoresSimulacao"].Value));
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Descricao",
                        value: dgvRow.Cells[columnName: "txtDescricao"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "txtDescricao"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue(parameterName: "@Data",
                        value: dgvRow.Cells[columnName: "txtData"].Value == DBNull.Value
                            ? ""
                            : dgvRow.Cells[columnName: "txtData"].Value.ToString());

                    double valorIva;
                    var item = dgvRow.Cells[columnName: "txtItem"].Value.ToString();
                    var query = @"SELECT CDU_IVA " + "FROM TDU_TRT_Items WHERE CDU_Nome = '" + item + "'";

                    var lstItem = PriEngine.Engine.Consulta(strQuery: query);

                    if (lstItem.Valor(vntCol: 0).ToString() == "False")
                        valorIva = 0;
                    else
                        valorIva = Convert.ToInt32(value: dgvRow.Cells[columnName: "txtValoresSimulacao"].Value) * 0.14;

                    var value = Convert.ToDouble(value: valorIva);
                    sqlCmd.Parameters.AddWithValue(parameterName: "@ValorIVASim",
                        value: value);
                    sqlCmd.ExecuteNonQuery();
                }
                catch
                {
                    //"Evita erro ao inicializar";
                }


            PopulaGrelha(processo: cbSERNumSimulacao.Text);

            var dgvRowTransport = dataGridViewSER.CurrentRow;
            // ReSharper disable once InvertIf
            if (dgvRowTransport != null && dgvRowTransport.Cells[columnName: "txtItem"].Value.ToString() == "TRANSPORTE + IVA")
                // ReSharper disable once InvertIf
                if (Convert.ToInt32(value: dgvRowTransport.Cells[columnName: "txtValoresSimulacao"].Value) > 0)
                {
                    var frmTransporte = new FrmTransporte(processo: cbSERNumSimulacao.Text);
                    frmTransporte.Show(owner: this);
                }
        }

        #endregion

        #region Form Fields

        public FrmServicos()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Anula a simulação escolhida, limpa os campos e carrega os numeros da simulaçao novamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSERAnula_Click(object sender, EventArgs e)
        {
            try
            {
                AnulaSimulacao();
                LimpaServicos();
                ActualizaDadosSimulacao();
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao anular a cotação {ex.Message}");
            }
        }

        /// <summary>
        ///     Apos a escolha de um numero de simulaçao o programa valida se existem dados ou nao
        ///     Se existem ele carrega os campos e a grelha.
        ///     Se for requisiçao valida se ja existe uma, caso exista carrega um textbox (txtSERRequisicao) com os dados da mesma.
        ///     E compara a data da simulaçao com a data actual, calcula os dias e caso sejam inferiores a 15 dias o fundo e verde
        ///     caso contrario o fundo e vermelho - Preenche o textbox txtSERValidaData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSERNumSimulacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var simulacao = cbSERNumSimulacao.Text;

            var lstExiste = PriEngine.Engine.Consulta(
                $"SELECT * FROM TDU_TRT_ItemsServicos WHERE CDU_Processo = '{cbSERNumSimulacao.Text}'");

            if (!lstExiste.Vazia() || lstExiste.Valor(0).ToString() != "")
            {
                CarregaServicos();
                PopulaGrelha(cbSERNumSimulacao.Text);
                cbSERNumSimulacao.Text = simulacao;
            }

            var documento = "REQ";
            var vendas = new IntegraPrimavera();

            var numReq = vendas.ExisteReq(simulacao, documento);

            if (numReq != "vazio")
            {
                txtSERRequisicao.Text = numReq;
                txtSERRequisicao.Visible = true;
            }
            else
            {
                txtSERRequisicao.Text = "";
                txtSERRequisicao.Visible = false;
            }

            var difDatas = (DateTime.Now.Date - Convert.ToDateTime(dtpSERData.Text)).TotalDays;
            if (difDatas > 0)
            {
                txtSERValidaData.Text = difDatas.ToString(CultureInfo.InvariantCulture);
                txtSERValidaData.Visible = true;

                if (difDatas > 15)
                    txtSERValidaData.BackColor = Color.Red;
                else
                    txtSERValidaData.BackColor = Color.Green;
            }
        }

        /// <summary>
        ///     Ao escolher uma entidade actualiza o textbox com o nome da mesma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSEREntidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizaDadosSimulacao();
            NomeCliente();
        }

        private void DataGridViewSER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        ///     Quando alteram o valor na grelha ele actualiza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSER_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GravaDadosGrelha();
        }

        /// <summary>
        ///     Conforme o valor escolhido ele carrega o campo das operaçoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSERCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSERCod.BackColor = Color.White;
            ActualizaOperacoes();
        }

        /// <summary>
        ///     Caso a opçao seja cotaçao ele cria logo uma simulaçao e fica a espera que sejam
        ///     preenchidos os valores. Caso seja requisiçao ele chama uma messagebox de confirmaçao
        ///     e depois um form para atribuir o tipo de processo, o numero do processo e criar tanto
        ///     nas nossas tabelas TDU_TRT como no ERP Primavera.
        ///     Se a opçao for factura de serviços cria nas nossas tabelas e no ERP, o processo nao existe
        ///     nestes casos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSEROperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSEROperacao.Text == @"Cotação" && cbSERNumSimulacao.Text != "")
            {
                try
                {
                    var lstExiste = PriEngine.Engine.Consulta(
                        $"SELECT CDU_Processo FROM TDU_TRT_ItemsServicos WHERE CDU_Processo = '{cbSERNumSimulacao.Text}'");

                    if (!lstExiste.Vazia())
                    {
                        CarregaServicos();
                    }
                    else
                    {
                        CriaSimulacao();
                        CriaServicos();
                    }

                    PopulaGrelha(cbSERNumSimulacao.Text);
                    ActualizaDadosSimulacao();
                }
                catch (Exception ex)
                {
                    PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar o serviço, {ex.Message}");
                }
            }
            else if (cbSEROperacao.Text == @"Requisição de fundos")
            {
                if (txtSERRequisicao.Text == "")
                {
                    var dialogResult = MessageBox.Show(@"Pretende converter uma simulação em requisição?",
                        @"Cria Requisições", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var frmRequisicao = new FrmRequisicao(cbSEREntidade.Text, dtpSERData.Value,
                            Convert.ToDouble(txtSERCambio.Text), cbSERNumSimulacao.Text);
                        frmRequisicao.Show(this);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        try
                        {
                            var tipoServ = string.Empty;
                            var strTipoServ =
                                $"SELECT CDU_Codigo FROM TDU_TRT_TiposServico WHERE CDU_Nome = '{cbSERCod.Text}'";
                            var lstTipoServ = PriEngine.Engine.Consulta(strTipoServ);

                            if (!lstTipoServ.Vazia()) tipoServ = "%" + lstTipoServ.Valor(0) + "%";

                            var frmTipoProcesso = new FrmTipoProcesso(tipoServ, cbSEROperacao.Text);
                            frmTipoProcesso.Show(this);
                        }
                        catch (Exception ex)
                        {
                            PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar a Requisição {ex.Message}");
                        }
                    }
                }
                else
                {
                    FrmRqa frmRqa = new FrmRqa(Convert.ToDouble(txtSERCambio.Text), dtpSERData.Value, 
                        txtSERNomeCliente.Text, txtSERProcesso.Text, cbSERNumSimulacao.Text);
                    frmRqa.Show(this);
                }
            }
            else if (cbSEROperacao.Text == @"Factura de Serviços")
            {
                try
                {
                    var lstExiste = PriEngine.Engine.Consulta(
                        $"SELECT CDU_Processo FROM TDU_TRT_ItemsServicos WHERE CDU_Processo = '{cbSERNumSimulacao.Text}'");

                    if (!lstExiste.Vazia())
                    {
                        CarregaServicos();
                    }
                    else
                    {
                        CriaSimulacao();
                        CriaServicos();
                    }

                    PopulaGrelha(cbSERNumSimulacao.Text);
                    ActualizaDadosSimulacao();
                }
                catch (Exception ex)
                {
                    PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar o serviço, {ex.Message}");
                }
            }
        }

        /// <summary>
        ///     Altera a cor dos campos atribuidos como obrigatorios.
        /// </summary>
        private void MudarCorCamposObrigatorios()
        {
            if (cbSERCod.Text == "") cbSERCod.BackColor = Color.LightBlue;
        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {

        }

        private void BntSERImprimir_Click(object sender, EventArgs e)
        {
            if (cbSERCod.Text != "")
                try
                {
                    if (cbSERNumSimulacao.Text != "")
                    {
                        UpdateSimulacao();
                        ImprimeSimulacao();
                    }
                }
                catch (Exception ex)
                {
                    PriEngine.Platform.Dialogos.MostraAviso($"Erro ao imprimir o mapa, {ex.Message}");
                }
            else
                MudarCorCamposObrigatorios();
        }

        private void BtnSERLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaServicos();
                ActualizaDadosSimulacao();
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso("Erro ao limpar o serviço: " + ex.Message);
            }
        }

        #endregion
    }
}
