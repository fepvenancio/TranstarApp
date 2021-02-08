using StdBE100;
using StdPlatBS100;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TRTv10.Engine;
using TRTv10.Integration;

namespace TRTv10.User_Interface
{
    public partial class FrmServicos : Form
    {
        #region variaveis

        private int _numSimulacao;
        private string _numProcesso;
        private bool _camposValidados;
        public string ValProcReq;
        private bool _criaReq;

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
        public void ActualizaListaNumSimulacao()
        {
            cbSERNumSimulacao.Items.Clear();
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
                while (!lstPesquisa.NoFim())
                {
                    cbSERNumSimulacao.Items.Add(item: lstPesquisa.Valor(0));
                    lstPesquisa.Seguinte();
                }
            }
        }

        /// <summary>
        ///     Se houver cliente selecionado vai buscar os codigos dos processos existentes
        ///     desse cliente, caso contrario, vai buscar todos os numeros de processo.
        /// </summary>
        public void ActualizaDadosProcesso()
        {
            cbSERNumSimulacao.Items.Clear();
            var sql = new StringBuilder();

            if (cbSEREntidade.Text == "")
            {
                sql.Append("SELECT CDU_Codigo ");
                sql.Append("FROM [dbo].[TDU_TRT_Processo] ");
            }
            else
            {
                sql.Append("SELECT CDU_Codigo ");
                sql.Append("FROM [dbo].[TDU_TRT_Processo] ");
                sql.Append("WHERE CDU_Cliente = '" + cbSEREntidade.Text + "' ");
            }

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (!lstPesquisa.Vazia())
            {
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

            if (chkSERRequisicao.Checked)
            {
                sql.Append("SELECT Max(Convert(int, CDU_Codigo)) ");
                sql.Append("FROM [dbo].[TDU_TRT_Processo] ");
            }
            else
            {
                sql.Append("SELECT Max(Convert(int, CDU_Codigo)) ");
                sql.Append("FROM [dbo].[TDU_TRT_Simulacao] ");
            }

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia() || lstPesquisa.Valor(0).ToString() == "")
            {
                if (chkSERCotacao.Checked)
                {
                    cbSERNumSimulacao.Text = @"COT1";
                }
                else
                {
                    cbSERNumSimulacao.Text = "";
                }
            }
            else
            {
                int numSimulacao = Convert.ToInt32(lstPesquisa.Valor(0)) + 1;

                if (chkSERCotacao.Checked)
                {
                    cbSERNumSimulacao.Text = @"COT" + numSimulacao;
                }/*
                else
                {
                    cbSERNumSimulacao.Text = numSimulacao.ToString();
                }*/
            }
        }

        /// <summary>
        /// Preenche os valores da combobox cbSERAviaoNavio
        /// </summary>
        public void ActualizaDadosTransporte()
        {
            cbSERAviaoNavio.Items.Clear();
            cbSERAviaoNavio.Items.Add("Marítimo");
            cbSERAviaoNavio.Items.Add("Avião");
            cbSERAviaoNavio.Items.Add("Rodoviário");
        }

        #endregion

        #region Metodos de Criaçao / Update

        private void ActualizaCbNumDoc()
        {
            cbSERNumDoc.Items.Clear();
            Motores motores = new Motores();
            string documento = motores.DevolveDocumento(cbSEROperacao.Text);
            string query;

            if (chkSERRequisicao.Checked is true)
            {
                query = $"SELECT CDU_Numero FROM TDU_TRT_Processo WHERE CDU_Documento = '{documento}' AND CDU_Codigo = '{cbSERNumSimulacao.Text}'";
            }
            else
            {
                query = $"SELECT CDU_Numero FROM TDU_TRT_Simulacao WHERE CDU_Documento = 'COT' AND CDU_Nome = '{cbSERNumSimulacao.Text}'";
            }

            StdBELista lstQ = PriEngine.Engine.Consulta(query);

            if (!lstQ.Vazia())
            {
                while (!lstQ.NoFim())
                {
                    cbSERNumDoc.Items.Add(lstQ.Valor(0));
                    lstQ.Seguinte();
                }
            }
            else
            {
                cbSERNumDoc.Items.Add(1);   
            }

            cbSERNumDoc.Text = cbSERNumDoc.Items[cbSERNumDoc.Items.Count - 1].ToString();
        }

        /// <summary>
        /// Serve para validar se para criar X documentos os campos essenciais estao preenchidos.
        /// </summary>
        private void ValidaCamposObrigatorios()
        {
            _camposValidados = false || cbSERCod.Text != ""
                && cbSEROperacao.Text != ""
                && cbSEREntidade.Text != ""
                && cbSERMoeda.Text != ""
                && txtSERVCIF.Text != ""
                && txtSERVAduaneiro.Text != ""
                && txtSERCambio.Text != ""
                && txtSERTipoMercadoria.Text != ""
                && cbSERAviaoNavio.Text != "";
        }

        /// <summary>
        ///     Carrega os valores da ComboBox Operaçao
        /// </summary>
        public void ActualizaCbOperacoes()
        {
            cbSEROperacao.Items.Clear();

            if (cbSERCod.Text == @"Despacho / Desalfandegamento")
            {
                cbSEROperacao.Items.Add("Cotação");
                cbSEROperacao.Items.Add("Requisição de fundos");
                cbSEROperacao.Items.Add("Requisição de fundos adicional");
            }
            else if (cbSERCod.Text == @"Licenciamento Fact/DUP")
            {
                cbSEROperacao.Items.Add("Cotação");
                cbSEROperacao.Items.Add("Requisição de fundos");
                cbSEROperacao.Items.Add("Requisição de fundos adicional");
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
                cbSEROperacao.Items.Add("Requisição de fundos adicional");
                cbSEROperacao.Items.Add("Factura de Serviços");
            }
        }

        /* Obsuleto
        /// <summary>
        /// Caso exista REQ ele carrega na combobox operaçao a
        /// possibilidade de fazer requisiçoes de fundos adicional
        /// </summary>
        private void ActualizaOperacoesRQA()
        {
            ActualizaOperacoes();
            Motores motores = new Motores();
            string reqNum;

            if (cbSERNumSimulacao.Text != "")
            {
                reqNum = motores.ExisteDoc(cbSERNumSimulacao.Text, DevolveDoc(cbSEROperacao.Text));

                if (reqNum != "vazio")
                {
                    if (cbSERCod.Text != @"Outros Serviços")
                    {
                        cbSEROperacao.Items.Add("Requisição de fundos adicional");
                    }
                }
            }
        }
        */

        /// <summary>
        /// Valida se o processo existe na tabela dos itemsServiços
        /// </summary>
        /// <returns></returns>
        private bool ExisteItensServicos()
        {
            string sqlQ = $"SELECT CDU_Processo FROM TDU_TRT_ItemsServicos WHERE CDU_Processo = '{cbSERNumSimulacao.Text}' ";
            StdBELista lstQ = PriEngine.Engine.Consulta(sqlQ);
            bool verdadeiro = false;

            if (!lstQ.Vazia())
            {
                verdadeiro = true;
            }

            return verdadeiro;
        }

        /// <summary>
        /// Valida se o processo existe e foi criado
        /// </summary>
        /// <returns></returns>
        private bool ExisteProcesso()
        {
            string sqlQ = $"SELECT CDU_Codigo FROM TDU_TRT_Processo WHERE CDU_Codigo = '{cbSERNumSimulacao.Text}'";
            StdBELista lstQ = PriEngine.Engine.Consulta(sqlQ);
            bool verdadeiro = false;

            if (!lstQ.Vazia())
            {
                verdadeiro = true;
            }

            return verdadeiro;
        }

        /// <summary>
        /// Corre querys no SQL
        /// </summary>
        /// <param name="query"></param>
        private void QueryDelete(string query)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connection.Close();
            }
        }

        /// <summary>
        /// Anula processos na BD
        /// </summary>
        private void AnulaProcesso()
        {
            string sqlQ = $"SELECT CDU_Codigo FROM TDU_TRT_Processo WHERE CDU_Codigo = '{cbSERNumSimulacao.Text}'";
            StdBELista lstQ = PriEngine.Engine.Consulta(sqlQ);

            if (!lstQ.Vazia() && cbSERNumSimulacao.Text != "")
            {
                StringBuilder sqlQDelServicos = new StringBuilder();
                string delProc = lstQ.Valor(0);
                bool existeItens = ExisteItensServicos();
                bool existeProc = ExisteProcesso();
                string qDelProc = $"DELETE FROM TDU_TRT_Processo WHERE CDU_Codigo = '{delProc}'";
                string qDelItens = $"DELETE FROM TDU_TRT_ItemsServicos WHERE CDU_Processo = '{delProc}'";

                if (existeItens is true)
                {
                    if (existeProc is false)
                    {
                        QueryDelete(qDelItens);
                        QueryDelete(qDelProc);
                    }
                }
                else
                {
                    if (existeProc is true)
                    {
                        QueryDelete(qDelProc);
                    }
                }

                ActualizaListaNumSimulacao();
                NumeroSimulacao();
                LimpaGrelha();
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

                ActualizaListaNumSimulacao();
                NumeroSimulacao();
                LimpaGrelha();
            }
            else
            {
                PriEngine.Platform.Dialogos.MostraAviso("A cotação que pretende apagar não existe.");
            }
        }

        /// <summary>
        ///     Faz update a tabela Simulação, isto e utilizado em Cotaçoes caso queiram alterar algo.
        /// </summary>
        private void UpdateSimulacao()
        {
            //confirma as datas como datas a serem inseridas no SQL - Formataçao
            DateTime data = dtpSERDataDU.Value;
            DateTime dataChegada = dtpSERDataDU.Value;
            DateTime dataEntrada= dtpSERDataDU.Value;
            DateTime dataSaida = dtpSERDataDU.Value;
            DateTime dataDu = dtpSERDataDU.Value;

            //troca as virgulas por pontos para serem inseridos no SQL - Formatacao
            IntegraPrimavera.validaNumeros(txtSERVCIF);
            IntegraPrimavera.validaNumeros(txtSERVAduaneiro);
            IntegraPrimavera.validaNumeros(txtSERCambio);
            IntegraPrimavera.validaNumeros(txtSERValorDAR);

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
        ///     Faz update a tabela Processo, isto e utilizado em Requisiçoes sem Cotaçao.
        /// </summary>
        private void UpdateProcesso(string processo)
        {
            //confirma as datas como datas a serem inseridas no SQL - Formataçao
            DateTime data = dtpSERDataDU.Value;
            DateTime dataChegada = dtpSERDataDU.Value;
            DateTime dataEntrada= dtpSERDataDU.Value;
            DateTime dataSaida = dtpSERDataDU.Value;
            DateTime dataDu = dtpSERDataDU.Value;

            //troca as virgulas por pontos para serem inseridos no SQL - Formatacao
            IntegraPrimavera.validaNumeros(txtSERVCIF);
            IntegraPrimavera.validaNumeros(txtSERVAduaneiro);
            IntegraPrimavera.validaNumeros(txtSERCambio);
            IntegraPrimavera.validaNumeros(txtSERValorDAR);

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            using (var transaction = sqlCon.BeginTransaction())
            {
                var sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaProcesso", sqlCon)
                {
                    Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@Processo", processo);
                sqlCmdLin.Parameters.AddWithValue("@Cliente", cbSEREntidade.Text);
                sqlCmdLin.Parameters.AddWithValue("@Moeda", cbSERMoeda.Text);
                sqlCmdLin.Parameters.AddWithValue("@Referencia", txtSERReferencia.Text);
                sqlCmdLin.Parameters.AddWithValue("@ValorCIF", txtSERVCIF.Text);
                sqlCmdLin.Parameters.AddWithValue("@ValorAduaneiro", txtSERVAduaneiro.Text);
                sqlCmdLin.Parameters.AddWithValue("@Cambio", txtSERCambio.Text);
                sqlCmdLin.Parameters.AddWithValue("@BLCartaPorte", txtSERBLCartaPorte.Text);
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
                sqlCmdLin.Parameters.AddWithValue("@RUP", txtSERRUP.Text);
                sqlCmdLin.Parameters.AddWithValue("@NumCot", "directo");
                sqlCmdLin.Parameters.AddWithValue("@Obs", txtSERObs.Text);
                sqlCmdLin.Parameters.AddWithValue("@NumVolumes", txtSERNumVolumes.Text);
                sqlCmdLin.ExecuteNonQuery();

                transaction.Commit();
            }
            sqlCon.Close();
        }

        /// <summary>
        ///     Ao escolherem um numero de simulaçao ele carrega os dados do SQL para a Form
        /// </summary>
        private void CarregaServicos()
        {
            var sql = new StringBuilder();

            if(chkSERRequisicao.Checked)
            {
                sql.Append("SELECT TOP(1) S.CDU_Nome, I.CDU_Operacao, U.CDU_Cliente, U.CDU_Data, U.CDU_Cambio ");
                sql.Append(", U.CDU_Moeda, U.CDU_Referencia, U.CDU_ValorCIF ");
                sql.Append(", U.CDU_ValorAduaneiro, U.CDU_BLCartaPorte, U.CDU_NumVolumes, U.CDU_Peso ");
                sql.Append(", U.CDU_AviaoNavio, U.CDU_Manifesto, U.CDU_NumDAR, U.CDU_ValorDAR ");
                sql.Append(", U.CDU_DU, U.CDU_DataChegada, U.CDU_DataEntrada, U.CDU_DataSaida ");
                sql.Append(", U.CDU_DataDU, U.CDU_DUP, U.CDU_CNCA, U.CDU_Obs, U.CDU_RUP, C.Nome, U.CDU_TipoMercadoria ");
                sql.Append(", U.CDU_Codigo, U.CDU_Numero ");
                sql.Append("FROM TDU_TRT_ItemsServicos I ");
                sql.Append("INNER JOIN TDU_TRT_Processo U ");
                sql.Append("ON I.CDU_Processo = U.CDU_Codigo ");
                sql.Append("INNER JOIN TDU_TRT_TiposServico S  ");
                sql.Append("ON I.CDU_TipoServ = S.CDU_Codigo ");
                sql.Append("INNER JOIN TDU_TRT_Items T ");
                sql.Append("ON T.CDU_Nome = I.CDU_Items ");
                sql.Append("INNER JOIN Clientes C ");
                sql.Append("ON C.Cliente = U.CDU_Cliente ");
                sql.Append("WHERE I.CDU_Processo = '" + cbSERNumSimulacao.Text + "' ");
                sql.Append("ORDER By T.CDU_Posicao");
            }
            else
            {
                sql.Append("SELECT TOP(1) S.CDU_Nome, I.CDU_Operacao, U.CDU_Cliente, U.CDU_Data, U.CDU_Cambio ");
                sql.Append(", U.CDU_Moeda, U.CDU_Referencia, U.CDU_ValorCIF ");
                sql.Append(", U.CDU_ValorAduaneiro, U.CDU_BLCartaPorte, U.CDU_NumVolumes, U.CDU_Peso ");
                sql.Append(", U.CDU_AviaoNavio, U.CDU_Manifesto, U.CDU_NumDAR, U.CDU_ValorDAR ");
                sql.Append(", U.CDU_DU, U.CDU_DataChegada, U.CDU_DataEntrada, U.CDU_DataSaida ");
                sql.Append(", U.CDU_DataDU, U.CDU_DUP, U.CDU_CNCA, U.CDU_Obs, U.CDU_RUP, C.Nome, U.CDU_TipoMercadoria ");
                sql.Append(", P.CDU_Codigo, U.CDU_Numero ");
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
            }
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
                cbSERNumDoc.Text = lstPesquisa.Valor(28).ToString();
            }
        }

        /// <summary>
        ///     Limpa todos os valores da Form
        /// </summary>
        public void LimpaServicos()
        {
            cbSERCod.Text = "";
            cbSEROperacao.Text = "";
            cbSERNumDoc.Text = "";
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
            
            LimpaTxtDataEReq();

            if (chkSERRequisicao.Checked)
            {
                ActualizaDadosProcesso();
            }
            else
            {
                ActualizaListaNumSimulacao();
            }
        }

        public void LimpaServicosCServico()
        {
            cbSEROperacao.Text = "";
            cbSEREntidade.Text = "";
            cbSERNumDoc.Text = "";
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
            
            LimpaTxtDataEReq();

            if (chkSERRequisicao.Checked)
            {
                ActualizaDadosProcesso();
            }
            else
            {
                ActualizaListaNumSimulacao();
            }
        }

        public void LimpaTxtDataEReq()
        {
            txtSERRequisicao.Text = "";
            txtSERRequisicao.BackColor = FrmServicos.DefaultBackColor;
            txtSERRequisicao.Visible = false;
            txtSERProcesso.Text = "";
            txtSERProcesso.BackColor = FrmServicos.DefaultBackColor;
            txtSERProcesso.Visible = false;
            txtSERValidaData.Text = "";
            txtSERValidaData.BackColor = FrmServicos.DefaultBackColor;
            txtSERValidaData.Visible = false;
        }

        /// <summary>
        /// Modelo de impressao dos mapas cotaçao
        /// </summary>
        /// <param name="processo"></param>
        /// <param name="documento"></param>
        private void EnviaImpressao(string processo, string documento, string docName)
        {
            PriEngine.Platform.Mapas.Inicializar("BAS");
            PriEngine.Platform.Mapas.Destino = StdBSTipos.CRPEExportDestino.edFicheiro;
            var list = Directory.GetFiles(@"\\192.168.10.10\primavera\SG100\Mapas\App", "*.pdf");
            int numerador = list.Length + 1;
            string fileName = string.Format("{0}_{1}_{2}.pdf", processo, documento, numerador);
            PriEngine.Platform.Mapas.SetFileProp(StdBSTipos.CRPEExportFormat.efPdf, @$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
            PriEngine.Platform.Mapas.JanelaPrincipal = 0;
            PriEngine.Platform.Mapas.SelectionFormula = $"{{TDU_TRT_ItemsServicos.CDU_Processo}} = '{processo}'";
            PriEngine.Platform.Mapas.ImprimeListagem($"TRT_SIM", docName);
            System.Diagnostics.Process.Start(@$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
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
                string codProcesso;

                if (cbSEROperacao.Text == @"Cotação" && cbSERNumSimulacao.Text != "")
                {
                    codProcesso = cbSERNumSimulacao.Text;
                    string documento = "COT";
                    string docName = "Cotação";

                    EnviaImpressao(codProcesso, documento, docName);

                }
                if (cbSEROperacao.Text == @"Requisição de fundos")
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    codProcesso = cbSERNumSimulacao.Text;

                    if (_criaReq)
                    {
                        codProcesso = ValProcReq;
                        var documento = "REQ";
                        var serie = DateTime.Now.Year.ToString();
                        var vendas = new IntegraPrimavera();
                        var cliente = cbSEREntidade.Text;
                        var cambio = Convert.ToDouble(txtSERCambio.Text);
                        var idOrig = Guid.NewGuid();
                        var idLin = Guid.NewGuid();

                        UpdateProcesso(codProcesso);

                        using (var sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();

                            using var transaction = sqlCon.BeginTransaction();
                            vendas.CriaDocumento(documento, serie, DateTime.Now, codProcesso, codProcesso,
                                sqlCon, transaction, idOrig, idLin, "", 0);
                            transaction.Commit();
                        }

                        Close();

                        using (var sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();

                            using var transaction = sqlCon.BeginTransaction();
                            vendas.CriaDocumentoErp(documento, cliente, DateTime.Now, cambio, serie,
                                codProcesso);
                            transaction.Commit();
                        }

                        PriEngine.Platform.Dialogos.MostraAviso("Documento criado com sucesso.");
                        Close();

                        _criaReq = false;
                    }

                    //imprimir
                }
                if (cbSEROperacao.Text == @"Requisição de fundos adicional")
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    
                    if (_criaReq)
                    {
                        codProcesso = cbSERNumSimulacao.Text;
                        var documento = "RQA";
                        var serie = DateTime.Now.Year.ToString();
                        var vendas = new IntegraPrimavera();
                        var cliente = cbSEREntidade.Text;
                        var cambio = Convert.ToDouble(txtSERCambio.Text);

                        UpdateProcesso(codProcesso);

                        using (var sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();

                            using var transaction = sqlCon.BeginTransaction();
                            vendas.CriaDocumentoErp(documento, cliente, DateTime.Now, cambio, serie,
                                codProcesso);
                            transaction.Commit();
                        }

                        PriEngine.Platform.Dialogos.MostraAviso("Documento criado com sucesso.");
                    }

                    
                    //Imprimir
                }
                if (cbSEROperacao.Text == @"Factura de Serviços" && cbSERNumSimulacao.Text != "")
                {
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

                    //Imprimir
                }
            }
            else
            {
                PriEngine.Platform.Dialogos.MostraAviso("Devem preencher os campos obrigatorios: Moeda, Valor CIF, Valor Aduaneiro, " +
                                                        "Câmbio, Tipo de Mercadoria e Data de Entrada ");
            }
        }

        public string DevolveDoc(string documento)
        {
            if (cbSEROperacao.Text == "Cotação")
            {
                documento = "COT";
                return documento;
            }
            if (cbSEROperacao.Text == "Requisição de fundos")
            {
                documento = "REQ";
                return documento;
            }
            if (cbSEROperacao.Text == "Requisição de fundos adicional")
            {
                documento = "RQA";
                return documento;
            }
            if (cbSEROperacao.Text == "Factura de Serviços")
            {
                documento = "FS";
                return documento;
            }
            
            documento = "REQ";
            return documento;
            
        }

        public Guid DevolveIdDoc()
        {
            if (cbSERNumSimulacao.Text != "")
            {
                Motores motores = new Motores();
                string documento = motores.DevolveDocumento(cbSEROperacao.Text);
                string query;

                if (documento == "COT")
                {
                    query = $"SELECT CDU_id FROM TDU_TRT_Simulacao WHERE CDU_Nome = '{cbSERNumSimulacao.Text}' ";
                }
                else
                {
                    query = $"SELECT CDU_id FROM TDU_TRT_Processo WHERE CDU_Codigo = '{cbSERNumSimulacao.Text}' AND CDU_Documento = '{documento}' " +
                            $"AND CDU_Numero = '{cbSERNumDoc.Text}'";
                }

                StdBELista lstQ = PriEngine.Engine.Consulta(query);
                if (!lstQ.Vazia()) 
                {
                    return lstQ.Valor(0);
                }
            }
            
            return Guid.Empty;
        }

        #endregion

        #region Grelha

        /// <summary>
        ///     Limpa os valores da grelha
        /// </summary>
        public void LimpaGrelha()
        {
            var dt = (DataTable) dataGridViewSER.DataSource;
            if (dt != null)
                dt.Clear();
        }

        /// <summary>
        ///     Carrega os valores da Tabela Items Serviços para a grelha
        /// </summary>
        /// <param name="processo"></param>
        public void PopulaGrelha(string processo)
        {
            var p = processo;
            var idDoc = DevolveIdDoc();

            try
            {
                if (idDoc != Guid.Empty)
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                    using var sqlCon = new SqlConnection(connectionString);
                    var sql = new StringBuilder();

                    sql.Append("SELECT S.CDU_Items, S.CDU_ValoresSimulacao, S.CDU_IVASimulacao ");
                    sql.Append(", S.CDU_Processo, S.CDU_Descricao, S.CDU_Data ");
                    sql.Append("FROM TDU_TRT_ItemsServicos S ");
                    sql.Append("INNER JOIN TDU_TRT_Items I ");
                    sql.Append("ON S.CDU_Items = I.CDU_Nome ");

                    if (cbSERNumSimulacao.Text != "")
                    {
                        sql.Append($"WHERE CDU_Processo = '{processo}' ");
                        sql.Append($"AND CDU_idDoc = '{idDoc}' ");
                    }
                    else
                    {
                        sql.Append("WHERE CDU_Processo = '0' ");
                    }

                    sql.Append("ORDER BY I.CDU_Posicao ");
                    var query = sql.ToString();

                    try
                    {
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
                        PriEngine.Platform.Dialogos.MostraAviso("Documento sem linhas");
                    }
                }
                else
                {
                    PriEngine.Platform.Diagnosticos.TraceMessage("Deve escolher um número de documento");
                }
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
            if (chkSERCotacao.Checked is true)
            {
                if (txtSERRequisicao.Text != "") return;
                try
                {
                    var connectionString = ConfigurationManager.ConnectionStrings[name: "ConnectionString"].ConnectionString;

                    if (dataGridViewSER.CurrentRow == null) return;
                    using var sqlCon = new SqlConnection(connectionString: connectionString);
                    sqlCon.Open();
                    var dgvRow = dataGridViewSER.CurrentRow;
                    var valSim = (double)dgvRow.Cells[columnName: "txtValoresSimulacao"].Value; 
                    var patternAlphabetic = @"([a-zA-Z])+";
                    var patternNumeric = @"([0-9])+";
                    var regex = new Regex(patternNumeric);
                    var match = regex.Match(patternAlphabetic);
                        
                    if (match.Success) 
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Deve escrever números e nao letras!");
                    }
                    else
                    {
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
                }
                catch
                {
                    //"Evita erro ao inicializar";
                }

                var dgvRowTransport = dataGridViewSER.CurrentRow;
                // ReSharper disable once InvertIf
                if (dgvRowTransport != null && dgvRowTransport.Cells[columnName: "txtItem"].Value.ToString() == "TRANSPORTE + IVA")
                    // ReSharper disable once InvertIf
                    if (Convert.ToInt32(value: dgvRowTransport.Cells[columnName: "txtValoresSimulacao"].Value) > 0)
                    {
                        var frmTransporte = new FrmTransporte(processo: cbSERNumSimulacao.Text);
                        frmTransporte.Show(owner: this);
                    }

                PopulaGrelha(cbSERNumSimulacao.Text);
            }
            else if (cbSEROperacao.Text == "Requisição de fundos adicional" && chkSERRequisicao.Checked is true)
            {
                if (txtSERRequisicao.Text != "") return;
                try
                {
                    var connectionString = ConfigurationManager.ConnectionStrings[name: "ConnectionString"].ConnectionString;

                    if (dataGridViewSER.CurrentRow == null) return;
                    using var sqlCon = new SqlConnection(connectionString: connectionString);
                    sqlCon.Open();
                    var dgvRow = dataGridViewSER.CurrentRow;
                    var valSim = (double)dgvRow.Cells[columnName: "txtValoresSimulacao"].Value; 
                    var patternAlphabetic = @"([a-zA-Z])+";
                    var patternNumeric = @"([0-9])+";
                    var regex = new Regex(patternNumeric);
                    var match = regex.Match(patternAlphabetic);
                        
                    if (match.Success) 
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Deve escrever números e nao letras!");
                    }
                    else
                    {
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
                }
                catch
                {
                    //"Evita erro ao inicializar";
                }

                var dgvRowTransport = dataGridViewSER.CurrentRow;
                // ReSharper disable once InvertIf
                if (dgvRowTransport != null && dgvRowTransport.Cells[columnName: "txtItem"].Value.ToString() == "TRANSPORTE + IVA")
                    // ReSharper disable once InvertIf
                    if (Convert.ToInt32(value: dgvRowTransport.Cells[columnName: "txtValoresSimulacao"].Value) > 0)
                    {
                        var frmTransporte = new FrmTransporte(processo: cbSERNumSimulacao.Text);
                        frmTransporte.Show(owner: this);
                    }

                PopulaGrelha(cbSERNumSimulacao.Text);
            }
        }

        #endregion

        #region Form Fields

        public FrmServicos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ao fechar a form limpa a form e a grelha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FrmServicosClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LimpaGrelha();
            LimpaServicos();
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
                if (chkSERCotacao.Checked)
                {
                    AnulaSimulacao();
                    LimpaServicos();
                    ActualizaListaNumSimulacao();
                }
                else
                {
                    AnulaProcesso();
                    LimpaServicos();
                    ActualizaDadosProcesso();
                }
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
            if (cbSERNumSimulacao.Text != "")
            {
                ActualizaCbNumDoc();
                LimpaTxtDataEReq();
                var simulacao = cbSERNumSimulacao.Text;

                
                Motores motores = new Motores();

                string numReq;
                string documento;    
                
                if (cbSEROperacao.Text != "")
                {
                    documento = DevolveDoc(cbSEROperacao.Text);
                    numReq = motores.ExisteDoc(simulacao, documento);
                }
                else
                {
                    documento = "REQ";
                    numReq = motores.ExisteDoc(simulacao, documento);
                }

                if (numReq != "vazio" && documento == "REQ")
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

                ActualizaCbOperacoes();
                LimpaGrelha();
                CarregaServicos();
                PopulaGrelha(cbSERNumSimulacao.Text);
            }
        }

        /// <summary>
        ///     Ao escolher uma entidade actualiza o textbox com o nome da mesma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSEREntidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var motores = new Motores();
            txtSERNomeCliente.Text = motores.GetNomeCliente(cbSEREntidade.Text);
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
            Motores motores = new Motores();

            if (chkSERCotacao.Checked is true)
            {
                var existeREQ = motores.ExisteDoc(cbSERNumSimulacao.Text, "REQ");
                if (existeREQ == "vazio")
                {
                    GravaDadosGrelha();
                }
                else
                {
                    PopulaGrelha(cbSERNumSimulacao.Text);
                }
            }
            else
            {
                PopulaGrelha(cbSERNumSimulacao.Text);
            }
        }

        /// <summary>
        ///     Conforme o valor escolhido ele carrega o campo das operaçoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSERCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSERCod.BackColor = Color.White;
        }

        /// <summary>
        /// Muda o visto para cotações e faz update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSEROperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSEROperacao.Text == "Requisição de fundos adicional")
            {
                LimpaGrelha();
                LimpaTxtDataEReq();
            }
            else if (cbSEROperacao.Text == "Requisição de fundos")
            {
                chkSERRequisicao.Checked = true;
            }
            else if (cbSEROperacao.Text == "Cotação")
            {
                chkSERCotacao.Checked = true;
            }
        }

        /// <summary>
        /// Caso seja uma REQ sem COT ele atribui um numero de processo baseado no
        /// cbSERAviaoNavio.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSERAviaoNavio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motores motores = new Motores();
            bool isCot = motores.IsCot(cbSERNumSimulacao.Text);
            
            if (isCot is false)
            {
                cbSERNumSimulacao.Text = "";
            }

            if (cbSEROperacao.Text == "Requisição de fundos")
            {
                cbSERNumSimulacao.Text = motores.GeraNumProcesso(cbSERAviaoNavio.Text);
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
                txtSERValidaData.BackColor = FrmServicos.DefaultBackColor;
                txtSERValidaData.Text = string.Empty;
                txtSERValidaData.Visible = false;
                txtSERRequisicao.Text = string.Empty;
                txtSERRequisicao.Visible = false;
                cbSERNumSimulacao.Text = string.Empty;
                LimpaServicos();
                LimpaGrelha();

                if (chkSERCotacao.Checked)
                {
                    ActualizaListaNumSimulacao();
                }
                else
                {
                    ActualizaDadosProcesso();
                }

                NumeroSimulacao();
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso("Erro ao limpar o serviço: " + ex.Message);
            }
        }

        private void chkSERCotacao_CheckedChanged(object sender, EventArgs e)
        {
            cbSERNumSimulacao.Text = "";
            chkSERRequisicao.Checked = !chkSERCotacao.Checked;
            //LimpaGrelha();
            //LimpaServicosCServico();
            ActualizaListaNumSimulacao();
            NumeroSimulacao();
        }
        
        private void chkSERRequisicao_CheckedChanged(object sender, EventArgs e)
        {
            cbSERNumSimulacao.Text = "";
            chkSERCotacao.Checked = !chkSERRequisicao.Checked;
            //LimpaGrelha();
            //LimpaServicosCServico();
            ActualizaDadosProcesso();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ValidaCamposObrigatorios();
            if (cbSERNumSimulacao.Text != "")
            {
                if (_camposValidados is true)
                { 
                    Motores motores = new Motores();

                    //Vai gravar na tabela simulacao e itemsServiços
                    if (cbSEROperacao.Text == @"Cotação" && cbSERNumSimulacao.Text != "")
                    {
                        motores.CriaCotacao(this);
                        ActualizaCbNumDoc();
                        DevolveIdDoc();
                        PopulaGrelha(cbSERNumSimulacao.Text);
                    }

                    //Se for nova vai gravar na tabela processos e itemsservicos
                    //Se for baseada numa cotaçao vai copiar das tabelas simulacao e 
                    //gravar nas tabelas processos e itemsservicos
                    //Depois cria na cabecdoc e linhasdoc (TDU_TRT_)
                    else if (cbSEROperacao.Text == @"Requisição de fundos")
                    {
                        string existeCOT = motores.ExisteDoc(cbSERNumSimulacao.Text, "COT");
                        string existeReq = motores.ExisteDoc(cbSERNumSimulacao.Text, "REQ");

                        Guid idDoc = Guid.NewGuid();

                        if (existeCOT == "vazio" && existeReq == "vazio")
                        {
                            chkSERRequisicao.Checked = true;
                            cbSERNumSimulacao.Text = motores.GeraNumProcesso(cbSERAviaoNavio.Text);
                            
                            motores.CriaRequisicao(this, false, "Sem Cotação", idDoc);
                            motores.CriaDocumento(this, "REQ", idDoc);
                            PopulaGrelha(cbSERNumSimulacao.Text);
                        }
                        else if (existeReq != "vazio")
                        {
                            PriEngine.Platform.Dialogos.MostraAviso($"A Requisiçao já existe na base de dados {existeReq}");
                        }
                        else if (existeCOT != "vazio")
                        {
                            PriEngine.Platform.Dialogos.MostraAviso($"Existe uma cotação - {existeCOT}, deve CONVERTER");
                        } 
                    }

                    //Vai gravar na tabela TDU_TRT_CabecDocumentos e ...LinhasDocumentos
                    else if (cbSEROperacao.Text == @"Requisição de fundos adicional")
                    {
                        Guid idDoc = Guid.NewGuid();

                        motores.CriaRequisicaoAdicional(this, false, "RQA", idDoc);
                        motores.CriaDocumento(this, "RQA", idDoc);
                        PopulaGrelha(cbSERNumSimulacao.Text);
                    }

                    //Vai gravar na tabela TDU_TRT_CabecDocumentos e ...LinhasDocumentos
                    else if ((cbSEROperacao.Text == @"Factura de Serviços")) 
                    {

                    }
                }
                else
                {
                    PriEngine.Platform.Dialogos.MostraAviso("Devem preencher os campos obrigatorios: Tipo de Serviço, Operacao, Cliente, Moeda, Valor CIF, Valor Aduaneiro, " +
                                                            "Câmbio, Tipo de Mercadoria e Data de Entrada ");
                }
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            ValidaCamposObrigatorios();
            try
            {
                if (cbSERNumSimulacao.Text != "" && cbSEROperacao.Text == "Cotação")
                {
                    string transporte = cbSERAviaoNavio.Text;
                    string numCot = cbSERNumSimulacao.Text;
                    Motores motores = new Motores();
                    string existeCOT = motores.ExisteDoc(numCot, "REQ");

                    if (_camposValidados is true)
                    {
                        if (existeCOT == "vazio")
                        {
                            var dialogResult = MessageBox.Show(@"Pretende converter uma cotação numa requisição?",
                                @"Cria Requisições", MessageBoxButtons.YesNo);

                            if (dialogResult != DialogResult.Yes) return;
                            
                            chkSERRequisicao.Checked = true;
                            
                            cbSERNumSimulacao.Text = motores.GeraNumProcesso(transporte);
                        
                            existeCOT = motores.ExisteDoc(numCot, "COT");
                            string existeReq = motores.ExisteDoc(numCot, "REQ");

                            if (existeCOT != "vazio" && existeReq == "vazio")
                            {
                                Guid idDoc = Guid.NewGuid();
                                motores.CriaRequisicao(this, true, numCot, idDoc);
                                motores.CriaDocumento(this, "REQ", idDoc);

                                LimpaServicos();
                                CarregaServicos();
                                PopulaGrelha(cbSERNumSimulacao.Text);
                            }
                        }
                        else
                        {
                            PriEngine.Platform.Dialogos.MostraAviso($"Já existe uma REQ para essa simulação: {existeCOT}" );
                        }
                    }
                    else
                    {
                        PriEngine.Platform.Dialogos.MostraAviso("Apenas as cotações podem ser convertidas.");
                    }
                }
                else
                {
                    PriEngine.Platform.Dialogos.MostraAviso("Apenas Cotações podem ser convertidas.");
                }

            }
            catch(Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao gerar a requisiçao: {ex.Message}");
            }
        }
    }
    #endregion
}
