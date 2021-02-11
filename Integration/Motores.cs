using StdBE100;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using StdPlatBS100;
using TRTv10.Engine;
using TRTv10.User_Interface;

namespace TRTv10.Integration
{
    class Motores
    {
        #region Novo Codigo

        #region Variaveis

        private Guid _idProcesso;
        private Guid _idDocumento;

        #endregion

        #region Tabela Documentos

        /// <summary>
        /// Aumenta o numerador dos documentos na base de dados
        /// </summary>
        /// <param name="documento"></param>
        public void AumentaNumeradorDocumentos(string documento)
        {
            var connectionString = GetConnectionString();

            using var sqlCon = new SqlConnection(connectionString);
            var sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaDocumentoNumerador", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmdLin.Parameters.AddWithValue("@documento", documento);
            sqlCon.Open();
            sqlCmdLin.ExecuteNonQuery();
            sqlCon.Close();
        }

        /// <summary>
        /// Cria documentos
        /// </summary>
        /// <param name=""></param>
        public void CriaDocumentos(string codigo, string descricao, int numerador, int ano, int numVias, bool preVisualiza,
            bool exportaPrimavera,  string codPrimavera, string natureza, string posicao, string tipoServ)
        {
            var connectionString = GetConnectionString();

            using var sqlCon = new SqlConnection(connectionString);
            SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_InsereDocumentos", sqlCon);
            sqlCmdLin.CommandType = CommandType.StoredProcedure;
            sqlCmdLin.Parameters.AddWithValue("@codigo", codigo);
            sqlCmdLin.Parameters.AddWithValue("@descricao", descricao);
            sqlCmdLin.Parameters.AddWithValue("@numerador", numerador);
            sqlCmdLin.Parameters.AddWithValue("@ano", ano);
            sqlCmdLin.Parameters.AddWithValue("@numVias", numVias);
            sqlCmdLin.Parameters.AddWithValue("@preVisualiza", preVisualiza);
            sqlCmdLin.Parameters.AddWithValue("@exportaPrimavera", exportaPrimavera);
            sqlCmdLin.Parameters.AddWithValue("@codPrimavera", codPrimavera);
            sqlCmdLin.Parameters.AddWithValue("@natureza", natureza);
            sqlCmdLin.Parameters.AddWithValue("@posicao", posicao);
            sqlCmdLin.Parameters.AddWithValue("@tipoServ", tipoServ);
            sqlCon.Open();
            sqlCmdLin.ExecuteNonQuery();
            sqlCon.Close();
        }

        /// <summary>
        /// Devolve o numerador do documento enviado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public int GetDocumentosNumerador(string codigo)
        {
            var query = $"SELECT CDU_Numerador FROM TDU_TRT_Documento WHERE CDU_Codigo = '{codigo}'";
            var lstQuery = PriEngine.Engine.Consulta(query);

            return !lstQuery.Vazia() ? (int) lstQuery.Valor(0) : 0;
        }

        /// <summary>
        /// Devolve se previsualiza determinado documento
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool GetDocumentosPreVisualiza(string codigo)
        {
            var query = $"SELECT CDU_Previsualiza FROM TDU_TRT_Documento WHERE CDU_Codigo = {codigo}";
            var lstQuery = PriEngine.Engine.Consulta(query);

            return !lstQuery.Vazia() && (bool) lstQuery.Valor(0);
        }

        /// <summary>
        /// Devolve o numerador do documento enviado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public int GetDocumentosExportaPrimavera(string codigo)
        {
            var query = $"SELECT CDU_ExportaPrimavera FROM TDU_TRT_Documento WHERE CDU_Codigo = {codigo}";
            var lstQuery = PriEngine.Engine.Consulta(query);

            return !lstQuery.Vazia() ? (int) lstQuery.Valor(0) : 0;
        }
        #endregion

        #region Tabela Ano

        public void CriaAno()
        {
            var ano = DateTime.Now.Year;
            var query = $"INSERT INTO TDU_TRT_Ano (CDU_Ano) VALUES ({ano})";
            
        }

        public bool ExisteAno(int ano)
        {
            var query = $"SELECT CDU_Ano FROM TDU_TRT_Ano WHERE CDU_Ano = {ano}";
            var lstQ = PriEngine.Engine.Consulta(query);

            return !lstQ.Vazia();
        }

        #endregion

        #region Items

        public bool ValidaSeItemTemIva(string item)
        {
            var query = $"SELECT CDU_IVA FROM TDU_TRT_Items WHERE CDU_Nome = '{item}'";
            var lstItem = PriEngine.Engine.Consulta(strQuery: query);

            return lstItem.Valor(vntCol: 0).ToString() != "False";
        }

        /// <summary>
        /// Devolve o codigo do item
        /// </summary>
        /// <param name="itemDescricao"></param>
        /// <returns></returns>
        public string GetItem(string itemDescricao)
        {
            var query = $"SELECT CDU_Codigo FROM TDU_TRT_Items WHERE CDU_Nome = '{itemDescricao}'";
            var lstQ = PriEngine.Engine.Consulta(query);
            return lstQ.Valor(0).ToString();
        }

        /// <summary>
        /// Devolve a % de iva de um Artigo
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public double PercentagemIva(string item)
        {
            var query = $"SELECT i.Taxa FROM Iva i INNER JOIN Artigo a ON i.Iva = a.Iva WHERE Artigo = '{item}'";
            var lstQ = PriEngine.Engine.Consulta(query);

            return !lstQ.Vazia() ? (double) lstQ.Valor(0) : 1;
        }

        #endregion

        #region Tabela Processo

        /// <summary>
        /// Cria na tabela do SQL TDU_TRT_Processo
        /// </summary>
        /// <param name="processo"></param>
        /// <param name="cliente"></param>
        /// <param name="nomeCliente"></param>
        /// <param name="moeda"></param>
        /// <param name="valorCif"></param>
        /// <param name="valorAduaneiro"></param>
        /// <param name="cambio"></param>
        /// <param name="cnca"></param>
        /// <param name="dup"></param>
        /// <param name="blCartaPorte"></param>
        /// <param name="rup"></param>
        /// <param name="referencia"></param>
        /// <param name="data"></param>
        /// <param name="dataChegada"></param>
        /// <param name="tipoMercadoria"></param>
        /// <param name="obs"></param>
        /// <param name="transporte"></param>
        /// <param name="manifesto"></param>
        /// <param name="numDar"></param>
        /// <param name="valorDar"></param>
        /// <param name="du"></param>
        /// <param name="numVolumes"></param>
        /// <param name="dataEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="dataDu"></param>
        /// <param name="peso"></param>
        public void CriaProcesso(string processo, string cliente, string nomeCliente, string moeda, double valorCif,
            double valorAduaneiro, double cambio, string cnca, string dup, string blCartaPorte, string rup, string referencia, DateTime data,
            DateTime dataChegada, string tipoMercadoria, string obs, string transporte, string manifesto, string numDar, string valorDar,
            string du, string numVolumes, DateTime dataEntrada, DateTime dataSaida, DateTime dataDu, double peso)
        {
            _idProcesso = Guid.NewGuid();

            var connectionString = GetConnectionString();
            using var sqlCon = new SqlConnection(connectionString);
            var sqlCmdLin = new SqlCommand("TDU_TRT_CriaProcesso", sqlCon);
            sqlCmdLin.CommandType = CommandType.StoredProcedure;
            sqlCmdLin.Parameters.AddWithValue("@id", _idProcesso);
            sqlCmdLin.Parameters.AddWithValue("@processo", processo);
            sqlCmdLin.Parameters.AddWithValue("@cliente", cliente);			
            sqlCmdLin.Parameters.AddWithValue("@nomeCliente", nomeCliente);		
            sqlCmdLin.Parameters.AddWithValue("@moeda", moeda);	
            sqlCmdLin.Parameters.AddWithValue("@valorCIF", valorCif);
            sqlCmdLin.Parameters.AddWithValue("@valorAduaneiro", valorAduaneiro);
            sqlCmdLin.Parameters.AddWithValue("@cambio", cambio);
            sqlCmdLin.Parameters.AddWithValue("@cnca", cnca);
            sqlCmdLin.Parameters.AddWithValue("@dup", dup);
            sqlCmdLin.Parameters.AddWithValue("@blCartaPorte", blCartaPorte);
            sqlCmdLin.Parameters.AddWithValue("@rup", rup);
            sqlCmdLin.Parameters.AddWithValue("@referencia", referencia);
            sqlCmdLin.Parameters.AddWithValue("@data ", data);
            sqlCmdLin.Parameters.AddWithValue("@dataChegada", dataChegada);		
            sqlCmdLin.Parameters.AddWithValue("@tipoMercadoria", tipoMercadoria);		
            sqlCmdLin.Parameters.AddWithValue("@obs", obs);
            sqlCmdLin.Parameters.AddWithValue("@transporte", transporte);
            sqlCmdLin.Parameters.AddWithValue("@manifesto", manifesto);
            sqlCmdLin.Parameters.AddWithValue("@numDAR", numDar);
            sqlCmdLin.Parameters.AddWithValue("@valorDAR", valorDar);
            sqlCmdLin.Parameters.AddWithValue("@dU", du);
            sqlCmdLin.Parameters.AddWithValue("@numVolumes", numVolumes);
            sqlCmdLin.Parameters.AddWithValue("@dataEntrada", dataEntrada);
            sqlCmdLin.Parameters.AddWithValue("@dataSaida", dataSaida);
            sqlCmdLin.Parameters.AddWithValue("@dataDU", dataDu);
            sqlCmdLin.Parameters.AddWithValue("@peso", peso);
            
            sqlCon.Open();
            sqlCmdLin.ExecuteNonQuery();
            sqlCon.Close();
        }

        #endregion

        #region Tabela CabecDocumento

        /// <summary>
        /// Cria o cabeçalho na TDU_TRT_CabecDocumentos
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="ano"></param>
        /// <param name="numero"></param>
        /// <param name="data"></param>
        /// <param name="moeda"></param>
        /// <param name="cambio"></param>
        /// <param name="observacoes"></param>
        /// <param name="processo"></param>
        /// <param name="cotacao"></param>
        /// <param name="tipoServ"></param>
        /// <param name="valorDoc"></param>
        /// <param name="valorIva"></param>
        /// <param name="valorRet"></param>
        /// <param name="valorTot"></param>
        /// <param name="valorRec"></param>
        /// <param name="utilizador"></param>
        /// <param name="cliente"></param>
        /// <param name="nome"></param>
        /// <param name="nif"></param>
        /// <param name="morada"></param>
        /// <param name="localidade"></param>
        /// <param name="codPostal"></param>
        /// <param name="codPostalLocalidade"></param>
        /// <param name="pais"></param>
        /// <param name="ivaCativo"></param>
        /// <param name="retencao"></param>
        public void CriaCabecDocumento(Guid idOrig, string documento, int ano, int numero, DateTime data, string moeda,
            double cambio, string observacoes, string processo, string cotacao, string tipoServ, 
            double valorDoc, double valorIva, double valorRet, double valorTot, double valorRec,
            string utilizador, string cliente, string nome, string nif, string morada, string localidade,
            string codPostal, string codPostalLocalidade, string pais, bool ivaCativo, bool retencao, DataGridView dataGridView)
        {
            var connectionString = GetConnectionString();
            using var sqlCon = new SqlConnection(connectionString);
            var sqlCmdLin = new SqlCommand("TDU_TRT_CriaCabecDocumentos", sqlCon);
            sqlCmdLin.CommandType = CommandType.StoredProcedure;
            sqlCmdLin.Parameters.AddWithValue("@IdProcesso", _idProcesso);
            sqlCmdLin.Parameters.AddWithValue("@Id", idOrig);
            sqlCmdLin.Parameters.AddWithValue("@Documento", documento);
            sqlCmdLin.Parameters.AddWithValue("@Ano", ano);
            sqlCmdLin.Parameters.AddWithValue("@Numero", numero);
            sqlCmdLin.Parameters.AddWithValue("@Data", data);
            sqlCmdLin.Parameters.AddWithValue("@Moeda", moeda);
            sqlCmdLin.Parameters.AddWithValue("@Cambio", cambio);
            sqlCmdLin.Parameters.AddWithValue("@Observacoes", observacoes);
            sqlCmdLin.Parameters.AddWithValue("@Processo", processo);
            sqlCmdLin.Parameters.AddWithValue("@Cotacao", cotacao);
            sqlCmdLin.Parameters.AddWithValue("@TipoServ", tipoServ);
            sqlCmdLin.Parameters.AddWithValue("@ValorDoc", valorDoc);
            sqlCmdLin.Parameters.AddWithValue("@ValorIva", valorIva);
            sqlCmdLin.Parameters.AddWithValue("@ValorRet", valorRet);
            sqlCmdLin.Parameters.AddWithValue("@ValorTot", valorTot);
            sqlCmdLin.Parameters.AddWithValue("@ValorRec", valorRec);
            sqlCmdLin.Parameters.AddWithValue("@Utilizador", utilizador);
            sqlCmdLin.Parameters.AddWithValue("@Cliente", cliente);
            sqlCmdLin.Parameters.AddWithValue("@Nome", nome);
            sqlCmdLin.Parameters.AddWithValue("@NIF", nif);
            sqlCmdLin.Parameters.AddWithValue("@Morada", morada);
            sqlCmdLin.Parameters.AddWithValue("@Localidade", localidade);
            sqlCmdLin.Parameters.AddWithValue("@CodPostal", codPostal);
            sqlCmdLin.Parameters.AddWithValue("@CodPostalLocalidade", codPostalLocalidade);
            sqlCmdLin.Parameters.AddWithValue("@Pais", pais);
            sqlCmdLin.Parameters.AddWithValue("@IVACativo", ivaCativo);
            sqlCmdLin.Parameters.AddWithValue("@Retencao", retencao);
            sqlCon.Open();
            sqlCmdLin.ExecuteNonQuery();
            CriaLinhasDocumento(idOrig, dataGridView, sqlCon);
            sqlCon.Close();
            AumentaNumeradorDocumentos(documento);
        }

        /// <summary>
        /// Faz update a tabela cabeçalho TDU_TRT_CabecDocumentos
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="ano"></param>
        /// <param name="numero"></param>
        /// <param name="data"></param>
        /// <param name="moeda"></param>
        /// <param name="cambio"></param>
        /// <param name="observacoes"></param>
        /// <param name="processo"></param>
        /// <param name="cotacao"></param>
        /// <param name="tipoServ"></param>
        /// <param name="valorDoc"></param>
        /// <param name="valorIva"></param>
        /// <param name="valorRet"></param>
        /// <param name="valorTot"></param>
        /// <param name="valorRec"></param>
        /// <param name="utilizador"></param>
        /// <param name="cliente"></param>
        /// <param name="nome"></param>
        /// <param name="nif"></param>
        /// <param name="morada"></param>
        /// <param name="localidade"></param>
        /// <param name="codPostal"></param>
        /// <param name="codPostalLocalidade"></param>
        /// <param name="pais"></param>
        /// <param name="ivaCativo"></param>
        /// <param name="retencao"></param>
        public void ActualizaCabecDocumento(string documento, int ano, int numero, DateTime data, string moeda,
            double cambio, string observacoes, string processo, string cotacao, string tipoServ, 
            double valorDoc, double valorIva, double valorRet, double valorTot, double valorRec,
            string utilizador, string cliente, string nome, string nif, string morada, string localidade,
            string codPostal, string codPostalLocalidade, string pais, bool ivaCativo, bool retencao)
        {
            var connectionString = GetConnectionString();
            var idProcesso = Guid.NewGuid(); //tem de ir buscar a guid

            using var sqlCon = new SqlConnection(connectionString);
            SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaCabecDocumentos", sqlCon);
            sqlCmdLin.CommandType = CommandType.StoredProcedure;
            sqlCmdLin.Parameters.AddWithValue("@IdProcesso", idProcesso);
            sqlCmdLin.Parameters.AddWithValue("@Documento", documento);
            sqlCmdLin.Parameters.AddWithValue("@Ano", ano);
            sqlCmdLin.Parameters.AddWithValue("@Numero", numero);
            sqlCmdLin.Parameters.AddWithValue("@Data", data);
            sqlCmdLin.Parameters.AddWithValue("@Moeda", moeda);
            sqlCmdLin.Parameters.AddWithValue("@Cambio", cambio);
            sqlCmdLin.Parameters.AddWithValue("@Observacoes", observacoes);
            sqlCmdLin.Parameters.AddWithValue("@Processo", processo);
            sqlCmdLin.Parameters.AddWithValue("@Cotacao", cotacao);
            sqlCmdLin.Parameters.AddWithValue("@TipoServ", tipoServ);
            sqlCmdLin.Parameters.AddWithValue("@ValorDoc", valorDoc);
            sqlCmdLin.Parameters.AddWithValue("@ValorIva", valorIva);
            sqlCmdLin.Parameters.AddWithValue("@ValorRet", valorRet);
            sqlCmdLin.Parameters.AddWithValue("@ValorTot", valorTot);
            sqlCmdLin.Parameters.AddWithValue("@ValorRec", valorRec);
            sqlCmdLin.Parameters.AddWithValue("@Utilizador", utilizador);
            sqlCmdLin.Parameters.AddWithValue("@Cliente", cliente);
            sqlCmdLin.Parameters.AddWithValue("@Nome", nome);
            sqlCmdLin.Parameters.AddWithValue("@NIF", nif);
            sqlCmdLin.Parameters.AddWithValue("@Morada", morada);
            sqlCmdLin.Parameters.AddWithValue("@Localidade", localidade);
            sqlCmdLin.Parameters.AddWithValue("@CodPostal", codPostal);
            sqlCmdLin.Parameters.AddWithValue("@CodPostalLocalidade", codPostalLocalidade);
            sqlCmdLin.Parameters.AddWithValue("@Pais", pais);
            sqlCmdLin.Parameters.AddWithValue("@IVACativo", ivaCativo);
            sqlCmdLin.Parameters.AddWithValue("@Retencao", retencao);

            sqlCon.Open();
            sqlCmdLin.ExecuteNonQuery();
            sqlCon.Close();
        }

        #endregion

        #region Tabela LinhasDocumento

        public void CriaLinhasDocumento(Guid idDoc, DataGridView dataGridView, SqlConnection sqlCon)
        {
            var i = 1;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                Guid id = Guid.NewGuid();
                if (row.Cells["Escolher"].Value is true)
                {
                    var item = Convert.ToString(row.Cells["Item"].Value);
                    var valor = Convert.ToDouble(row.Cells["Valor"].Value);
                    var valorIva = Convert.ToDouble(row.Cells["Valor Iva"].Value);

                    SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_CriaLinhasDoc", sqlCon);
                    sqlCmdLin.CommandType = CommandType.StoredProcedure;
                    sqlCmdLin.Parameters.AddWithValue("@idDoc", idDoc);
                    sqlCmdLin.Parameters.AddWithValue("@id", id);
                    sqlCmdLin.Parameters.AddWithValue("@i", i);
                    sqlCmdLin.Parameters.AddWithValue("@item", item);
                    sqlCmdLin.Parameters.AddWithValue("@qtd", 1);
                    sqlCmdLin.Parameters.AddWithValue("@precUnit", valor);
                    sqlCmdLin.Parameters.AddWithValue("@total", valor);
                    sqlCmdLin.Parameters.AddWithValue("@precIva", valorIva);
                    sqlCmdLin.Parameters.AddWithValue("@totalRec", valorIva);
                    sqlCmdLin.Parameters.AddWithValue("@aprovado", 0);
                    sqlCmdLin.ExecuteNonQuery();
                    i++;
                }
            }
        }

        public void ActualizaLinhasDocumento(string documento, int ano, int numero, DateTime data, string moeda,
            double cambio, string observacoes, string processo, string cotacao, string tipoServ, 
            double valorDoc, double valorIva, double valorRet, double valorTot, double valorRec,
            string utilizador, string cliente, string nome, string nif, string morada, string localidade,
            string codPostal, string codPostalLocalidade, string pais, bool ivaCativo, bool retencao)
        {
            var connectionString = GetConnectionString();
            Guid id = Guid.Empty;

            using var sqlCon = new SqlConnection(connectionString);
            SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_InsereDocumentos", sqlCon);
            sqlCmdLin.CommandType = CommandType.StoredProcedure;
            sqlCmdLin.Parameters.AddWithValue("@Id", id);
            sqlCmdLin.Parameters.AddWithValue("@Documento", documento);
            sqlCmdLin.Parameters.AddWithValue("@Ano", ano);
            sqlCmdLin.Parameters.AddWithValue("@Numero", numero);
            sqlCmdLin.Parameters.AddWithValue("@Data", data);
            sqlCmdLin.Parameters.AddWithValue("@Moeda", moeda);
            sqlCmdLin.Parameters.AddWithValue("@Cambio", cambio);
            sqlCmdLin.Parameters.AddWithValue("@Observacoes", observacoes);
            sqlCmdLin.Parameters.AddWithValue("@Processo", processo);
            sqlCmdLin.Parameters.AddWithValue("@Cotacao", cotacao);
            sqlCmdLin.Parameters.AddWithValue("@TipoServ", tipoServ);
            sqlCmdLin.Parameters.AddWithValue("@ValorDoc", valorDoc);
            sqlCmdLin.Parameters.AddWithValue("@ValorIva", valorIva);
            sqlCmdLin.Parameters.AddWithValue("@ValorRet", valorRet);
            sqlCmdLin.Parameters.AddWithValue("@ValorTot", valorTot);
            sqlCmdLin.Parameters.AddWithValue("@ValorRec", valorRec);
            sqlCmdLin.Parameters.AddWithValue("@Utilizador", utilizador);
            sqlCmdLin.Parameters.AddWithValue("@Cliente", cliente);
            sqlCmdLin.Parameters.AddWithValue("@Nome", nome);
            sqlCmdLin.Parameters.AddWithValue("@NIF", nif);
            sqlCmdLin.Parameters.AddWithValue("@Morada", morada);
            sqlCmdLin.Parameters.AddWithValue("@Localidade", localidade);
            sqlCmdLin.Parameters.AddWithValue("@CodPostal", codPostal);
            sqlCmdLin.Parameters.AddWithValue("@CodPostalLocalidade", codPostalLocalidade);
            sqlCmdLin.Parameters.AddWithValue("@Pais", pais);
            sqlCmdLin.Parameters.AddWithValue("@IVACativo", ivaCativo);
            sqlCmdLin.Parameters.AddWithValue("@Retencao", retencao);

            sqlCon.Open();
            sqlCmdLin.ExecuteNonQuery();
            sqlCon.Close();
        }

        #endregion

        #region Combo Box

        /// <summary>
        ///     Carrega o codigo dos Tipos de Serviços na combobox da tabela TiposServico
        /// </summary>
        public ComboBox GetTipoServ(ComboBox cbComboBox)
        {
            var sql = new StringBuilder();

            sql.Append("SELECT CDU_Nome ");
            sql.Append("FROM [dbo].[TDU_TRT_TiposServico] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia()) return cbComboBox;
            cbComboBox.Items.Clear();

            while (!lstPesquisa.NoFim())
            {
                cbComboBox.Items.Add(item: lstPesquisa.Valor(0));
                lstPesquisa.Seguinte();
            }

            return cbComboBox;
        }

        /// <summary>
        ///     Carrega os valores da ComboBox Operaçao
        /// </summary>
        public ComboBox GetOperacoes(ComboBox cbComboBox, string tipoServ)
        {
            cbComboBox.Items.Clear();

            if (tipoServ == @"Despacho / Desalfandegamento")
            {
                cbComboBox.Items.Add("Cotação");
                cbComboBox.Items.Add("Requisição de fundos");
                cbComboBox.Items.Add("Requisição de fundos adicional");
            }
            else if (tipoServ == @"Licenciamento Fact/DUP")
            {
                cbComboBox.Items.Add("Cotação");
                cbComboBox.Items.Add("Requisição de fundos");
                cbComboBox.Items.Add("Requisição de fundos adicional");
                cbComboBox.Items.Add("Factura de Serviços");

            }
            else if (tipoServ == @"Outros Serviços")
            {
                cbComboBox.Items.Add("Cotação");
                cbComboBox.Items.Add("Factura de Serviços");
            }
            else
            {
                cbComboBox.Items.Add("Cotação");
                cbComboBox.Items.Add("Requisição de fundos");
                cbComboBox.Items.Add("Requisição de fundos adicional");
                cbComboBox.Items.Add("Factura de Serviços");
            }

            return cbComboBox;
        }

        /// <summary>
        ///     Carrega o codigo dos Tipos de Serviços na combobox da tabela TiposServico
        /// </summary>
        public ComboBox GetClientes(ComboBox cbComboBox)
        {
            var sql = new StringBuilder();

            sql.Append("SELECT Cliente ");
            sql.Append("FROM [dbo].[Clientes] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia()) return cbComboBox;
            cbComboBox.Items.Clear();

            while (!lstPesquisa.NoFim())
            {
                cbComboBox.Items.Add(item: lstPesquisa.Valor(0));
                lstPesquisa.Seguinte();
            }

            return cbComboBox;
        }

        /// <summary>
        /// Preenche os valores da combobox cbSERAviaoNavio
        /// </summary>
        public ComboBox GetDadosTransporte(ComboBox cbComboBox)
        {
            cbComboBox.Items.Clear();
            cbComboBox.Items.Add("Marítimo");
            cbComboBox.Items.Add("Avião");
            cbComboBox.Items.Add("Rodoviário");
            return cbComboBox;
        }

        /// <summary>
        /// Preenche a combobox com todos os numeros de COT
        /// </summary>
        /// <param name="cbComboBox"></param>
        /// <returns></returns>
        public ComboBox GetNumeros(ComboBox cbComboBox, string codDoc)
        {
            cbComboBox.Items.Clear();
            var numerador = GetDocumentosNumerador(codDoc);
            for (int i = 1; i <= numerador; i++)
            {
                cbComboBox.Items.Add(i);
            }
            return cbComboBox;
        }

        /// <summary>
        /// Preenche a combobox com numeros do
        /// </summary>
        /// <param name="cbComboBox"></param>
        /// <returns></returns>
        public ComboBox GetProcessos(ComboBox cbComboBox)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT CDU_Processo ");
            sql.Append("FROM TDU_TRT_Processo ");
            sql.Append("WHERE CDU_Processo is not null AND CDU_Processo not like '%C%' ");
            var query = sql.ToString();
            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia()) return cbComboBox;
            cbComboBox.Items.Clear();

            while (!lstPesquisa.NoFim())
            {
                cbComboBox.Items.Add(item: lstPesquisa.Valor(0));
                lstPesquisa.Seguinte();
            }

            return cbComboBox;
        }

        /// <summary>
        /// Preenche a combobox com numeros do processo
        /// </summary>
        /// <param name="cbComboBox"></param>
        /// <returns></returns>
        public ComboBox GetMoedas(ComboBox cbComboBox)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT Moeda ");
            sql.Append("FROM [dbo].[Moedas] ");
            var query = sql.ToString();
            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia()) return cbComboBox;
            cbComboBox.Items.Clear();

            while (!lstPesquisa.NoFim())
            {
                cbComboBox.Items.Add(item: lstPesquisa.Valor(0));
                lstPesquisa.Seguinte();
            }

            return cbComboBox;
        }

        /// <summary>
        /// Vai buscar os anos existentes na BD para
        /// preencher a combobox Ano
        /// </summary>
        /// <param name="cbComboBox"></param>
        /// <returns></returns>
        public ComboBox GetAnos(ComboBox cbComboBox)
        {
            var sql = new StringBuilder();

            sql.Append("SELECT CDU_Ano ");
            sql.Append("FROM [dbo].[TDU_TRT_Ano] ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia()) return cbComboBox;
            cbComboBox.Items.Clear();

            while (!lstPesquisa.NoFim())
            {
                cbComboBox.Items.Add(item: lstPesquisa.Valor(0));
                lstPesquisa.Seguinte();
            }

            return cbComboBox;

        }

        #endregion

        #region Devolve Valores

        public bool ValidaRequisicaoProcessoExiste(string processo)
        {
            var query = $"SELECT CDU_Documento FROM TDU_TRT_CabecDocumentos WHERE CDU_Processo = '{processo}' AND CDU_Documento = 'REQ'";
            var lstQ = PriEngine.Engine.Consulta(query);
            if (!lstQ.Vazia() || !lstQ.NoFim())
            {
                return true;
            }

            return false;
        }

        public string GetReqDocumentoNumAno(string documento, int ano, int numero)
        {
            var doc = "false";
            var cotacao = $"{documento} {numero}/{ano}";
            var query = $"SELECT CDU_Documento, CDU_Numero, CDU_Ano FROM TDU_TRT_CabecDocumentos WHERE CDU_Cotacao = '{cotacao}' AND CDU_Documento = 'REQ'";
            var lstQ = PriEngine.Engine.Consulta(query);
            if (!lstQ.Vazia() || lstQ.NoFim())
            {
                doc = lstQ.Valor(0).ToString() + " " + lstQ.Valor(1).ToString() + "/" + lstQ.Valor(2).ToString();
            };

            return doc;
        }

        /// <summary>
        /// Valida se ja existe uma REQ com a cotaçao enviada
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="ano"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool ValidaReqConvertidaExiste(string documento, int ano, int numero)
        {
            var cotacao = $"{documento} {numero}/{ano}";
            var query = $"SELECT CDU_Cotacao FROM TDU_TRT_CabecDocumentos WHERE CDU_Cotacao = '{cotacao}'";
            var lstQ = PriEngine.Engine.Consulta(query);
            return !lstQ.Vazia() || lstQ.NoFim();
        }

        /// <summary>
        /// Atraves to tipo de transporte indica o proximo numero
        /// de processo a utilizar
        /// </summary>
        /// <param name="transporte"></param>
        /// <returns></returns>
        public string GeraNumProcesso(string transporte)
        {
            var sql = new StringBuilder();
            var tipoProc = String.Empty;
            var ano = DateTime.Now.Year.ToString();
            var substring = ano.Substring(ano.Length - 2);

            switch (transporte)
            {
                case "Marítimo":
                    tipoProc = "1";
                    break;
                case "Avião":
                    tipoProc = "2";
                    break;
                case "Rodoviário":
                    tipoProc = "3";
                    break;
            }

            var processo = substring + tipoProc + "%";

            sql.Append("SELECT MAX(RIGHT(CDU_Processo, 4)) ");
            sql.Append("FROM [dbo].[TDU_TRT_Processo] ");
            sql.Append("WHERE CDU_Processo LIKE '" + processo + "' ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia() || lstPesquisa.Valor(0).ToString() == "")
            {
                processo = substring + tipoProc + "0001";
            }
            else
            {
                int maxCodigo = Convert.ToInt32(lstPesquisa.Valor(0)) + 1;
                processo = String.Empty;

                if (maxCodigo.ToString().Length == 1)
                    processo = substring + tipoProc + "000" + maxCodigo;
                else if (maxCodigo.ToString().Length == 2)
                    processo = substring + tipoProc + "00" + maxCodigo;
                else if (maxCodigo.ToString().Length == 3) processo = substring + tipoProc + "0" + maxCodigo;
            }

            return processo;
        }

        /// <summary>
        /// Devolve o id do processo baseado no documento usado para criar o processo
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="ano"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public Guid GetIdProcesso(string documento, int ano, int numero)
        {
            var q = new StringBuilder();
            q.Append("SELECT P.CDU_Id ");
            q.Append("FROM TDU_TRT_Processo P ");
            q.Append("INNER JOIN TDU_TRT_CabecDocumentos C ON C.CDU_IdProcesso = P.CDU_id ");
            q.Append($"WHERE C.CDU_Documento = '{documento}' ");
            q.Append($"AND C.CDU_Ano = {ano} ");
            q.Append($"AND C.CDU_Numero = {numero} ");
            var query = q.ToString();
            var lstQ = PriEngine.Engine.Consulta(query);
            var idProcesso = Guid.Empty;

            if (!lstQ.Vazia() || lstQ.NoFim())
            {
                idProcesso = lstQ.Valor(0);
            }
            
            return idProcesso;
        }

        /// <summary>
        /// Vai ao cliente e valida se tem retençao e qual a percentagem
        /// </summary>
        /// <returns></returns>
        public float GetPercRetencao(string cliente)
        {
            float percRet = 0;
            var query = $"SELECT Valor FROM OutrasRetencoes WHERE TipoEntidade = 'C' AND Entidade = '{cliente}'";
            var lstQ = PriEngine.Engine.Consulta(query);

            if (!lstQ.Vazia())
            {
                percRet = lstQ.Valor(0);
            }

            return percRet;
        }

        /// <summary>
        /// Vai ao ERP e devolve os dados dos clientes
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public string[] GetDadosCliente(string cliente)
        {
            var query =
                $"SELECT Nome, NumContrib, Fac_Mor, Fac_Local, Fac_Cp, Fac_Cploc, Pais, IVACativo, EfectuaRetencao FROM Clientes WHERE Cliente = '{cliente}'";
            var lstQ = PriEngine.Engine.Consulta(query);
            var dadosCliente = new string[9];

            if (lstQ.Vazia()) return dadosCliente;

            if (lstQ.Valor(0).ToString() != "")
            {
                dadosCliente[0] = lstQ.Valor(0);
            }
            else
            {
                dadosCliente[0] = "";
            }
            if (lstQ.Valor(1).ToString() != "")
            {
                dadosCliente[1] = lstQ.Valor(1);
            }
            else
            {
                dadosCliente[1] = "";
            }
            if (lstQ.Valor(2).ToString() != "")
            {
                dadosCliente[2] = lstQ.Valor(2);
            }
            else
            {
                dadosCliente[2] = "";
            }
            if (lstQ.Valor(3).ToString() != "")
            {
                dadosCliente[3] = lstQ.Valor(3);
            }
            else
            {
                dadosCliente[3] = "";
            }
            if (lstQ.Valor(4).ToString() != "")
            {
                dadosCliente[4] = lstQ.Valor(4);
            }
            else
            {
                dadosCliente[4] = "";
            }
            if (lstQ.Valor(5).ToString() != "")
            {
                dadosCliente[5] = lstQ.Valor(5);
            }
            else
            {
                dadosCliente[5] = "";
            }
            if (lstQ.Valor(6).ToString() != "")
            {
                dadosCliente[6] = lstQ.Valor(6);
            }
            else
            {
                dadosCliente[6] = "";
            }

            dadosCliente[7] = Convert.ToString(lstQ.Valor(7));
            dadosCliente[8] = Convert.ToString(lstQ.Valor(8));
            return dadosCliente;
        }

        /// <summary>
        /// Valida se o documento que esta a gravar ja existe
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="numero"></param>
        /// <param name="ano"></param>
        /// <returns></returns>
        public bool ExisteDocumento(string documento, int numero, int ano)
        {
            var query = $"SELECT CDU_Id FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '{documento}' AND CDU_Numero = {numero} AND CDU_Ano = {ano}";
            var lstQ = PriEngine.Engine.Consulta(query);

            return !lstQ.Vazia();
        }

        /// <summary>
        /// Recebe uma TextBox e altera o texto da mesma, ou seja, caso a textbox tenha uma virgula
        /// ele altera para um ponto Ex. 1000,10 -> 1000.10 para cumprir com a formataçao do SQL.
        /// </summary>
        /// <param name="sender"></param>
        public TextBox ValidaSeTextBoxENumerica(TextBox textBox)
        {
            StringBuilder altText = new StringBuilder(textBox.Text);
            altText.Replace(",", ".");
            textBox.Text = altText.ToString();
            return textBox;
        }

        /// <summary>
        /// Vai a base de dados e corre uma query para ir buscar o documento caso exista
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="numero"></param>
        /// <param name="ano"></param>
        /// <returns></returns>
        public StdBELista GetDadosForm(string documento, int numero, int ano)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT P.CDU_Cliente, P.CDU_NomeCliente, P.CDU_Moeda "); //3
            sql.Append(",P.CDU_ValorCIF, P.CDU_ValorAduaneiro, P.CDU_Cambio, P.CDU_CNCA, P.CDU_DUP "); //8
            sql.Append(",P.CDU_BLCartaPorte, P.CDU_RUP, P.CDU_Referencia, P.CDU_Data, P.CDU_DataChegada "); //12
            sql.Append(",P.CDU_TipoMercadoria, P.CDU_Obs, P.CDU_Transporte, P.CDU_Manifesto, P.CDU_NumDAR "); //17
            sql.Append(",P.CDU_ValorDAR, P.CDU_DU, P.CDU_NumVolumes, P.CDU_DataEntrada, P.CDU_DataSaida "); //22
            sql.Append(",P.CDU_DataDU, P.CDU_Peso "); //24
            sql.Append(",C.CDU_ValorDoc, C.CDU_ValorIva, C.CDU_ValorRet, C.CDU_ValorTot "); //28
            sql.Append("FROM dbo.TDU_TRT_Processo P ");
            sql.Append("INNER JOIN dbo.TDU_TRT_CabecDocumentos C ");
            sql.Append("ON C.CDU_IdProcesso = P.CDU_id ");
            sql.Append($"WHERE C.CDU_Documento = '{documento}' AND C.CDU_Ano = {ano} AND C.CDU_Numero = {numero} ");
            var query = sql.ToString();
            var lstDados = PriEngine.Engine.Consulta(query);
            return lstDados;
        }

        /// <summary>
        /// Vai buscar a connection string do programa SQL:APP
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            return connectionString;
        }

        /// <summary>
        /// Vai buscar o nome do Cliente
        /// </summary>
        /// <param name="codCliente"></param>
        /// <returns></returns>
        public string GetNomeCliente(string codCliente)
        {
            var nomeCliente = String.Empty;

            if (codCliente != "") nomeCliente = PriEngine.Engine.Base.Clientes.DaNome(codCliente);

            return nomeCliente;
        }

        /// <summary>
        /// Vai buscar o codigo do documento
        /// </summary>
        /// <param name="codCliente"></param>
        /// <returns></returns>
        public string GetCodigoDocumento(string descricao)
        {
            var query = $"SELECT CDU_Codigo FROM [dbo].[TDU_TRT_Documento] WHERE CDU_Descricao = '{descricao}'";
            var lstQuery = PriEngine.Engine.Consulta(query);
            string codigoDoc = "0";

            if (lstQuery.Vazia()) return codigoDoc;
            codigoDoc = lstQuery.Valor(0);
            return codigoDoc;
        }

        /// <summary>
        /// Devolve o valor do cambio de venda da moeda enviada
        /// </summary>
        /// <param name="moeda"></param>
        /// <returns></returns>
        public double GetMoedaCambio(string moeda)
        {
            double cambio = 0;

            if (moeda != "") cambio = PriEngine.Engine.Base.Moedas.DaCambioVenda(moeda, DateTime.Now);

            return cambio;
        }

        /// <summary>
        /// Valida se o documento existe
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool GetExisteDoc(string documento, int numero, int ano)
        {
            var query = $"SELECT CDU_id FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '{documento}' AND CDU_Numero = {numero} " +
                        $"AND CDU_Ano = {ano}";
            var lstQ = PriEngine.Engine.Consulta(query);

            if(!lstQ.Vazia())
            {
                _idDocumento = lstQ.Valor(0);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Vai buscar os item da tabela TDU_TRT_Items e preenche a grelha
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public DataGridView GetItems(DataGridView dataGridView, bool existeDoc)
        {
            string qItems;
            StdBELista lstQ;

            DataTable tabela = new DataTable();
 
            tabela.Columns.Add("Escolher", typeof(bool));
            tabela.Columns.Add("Item", typeof(string));
            tabela.Columns.Add("Valor", typeof(double));
            tabela.Columns.Add("Valor Iva", typeof(double));

            if (existeDoc is false)
            {
                qItems = "SELECT CDU_Nome FROM TDU_TRT_Items";
                lstQ = PriEngine.Engine.Consulta(qItems);

                if (!lstQ.Vazia())
                {
                    while (!lstQ.NoFim())
                    {
                        string item = lstQ.Valor(0);
                        tabela.Rows.Add(false, item, 0, 0);
                        lstQ.Seguinte();
                    }
                }
            }
            else
            {
                qItems = $"SELECT CDU_Item, CDU_PrecUnit, CDU_PrecIVA FROM TDU_TRT_LinhasDocumentos WHERE CDU_IdDoc = '{_idDocumento}'";
                lstQ = PriEngine.Engine.Consulta(qItems);

                if (!lstQ.Vazia())
                {
                    while (!lstQ.NoFim())
                    {
                        string item = lstQ.Valor(0);
                        double valor = lstQ.Valor(1);
                        double valorIva = lstQ.Valor(2);
                        tabela.Rows.Add(false, item, valor, valorIva);
                        lstQ.Seguinte();
                    }
                }
            }

            try
            {

                dataGridView.DataSource = tabela;
                dataGridView.Columns[0].Width = 60;
                dataGridView.Columns[0].ReadOnly = false;
                dataGridView.Columns[1].Width = 325;
                dataGridView.Columns[1].ReadOnly = true;
                dataGridView.Columns[2].Width = 100;
                dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView.Columns[2].ReadOnly = false;
                dataGridView.Columns[3].Width = 100;
                dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView.Columns[3].ReadOnly = true;
            }
            catch
            {
                PriEngine.Platform.Dialogos.MostraAviso("Não existem Items para carregar!");
            }

            return dataGridView;
        }

        #endregion
        
        #region Form

        /// <summary>
        /// Apaga todos os controls da form
        /// </summary>
        /// <param name="form"></param>
        public void ApagaDadosForm(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = null;
                }

                if (control is ComboBox comboBox)
                {
                    if (comboBox.Items.Count > 0)
                        comboBox.Items.Clear();
                    
                    comboBox.Text = "";
                }

                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

                if (control is ListBox listBox)
                {
                    listBox.ClearSelected();
                }
            }
        }

        #endregion

        #region Grelha

        /// <summary>
        /// Le e carrega os items para a grelha
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="documento"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public DataGridView PopulaGrelha(DataGridView dataGridView, string documento, int numero, int ano)
        {
            var existeDoc = GetExisteDoc(documento, numero, ano);
            GetItems(dataGridView, existeDoc);
            return dataGridView;
        }

        /// <summary>
        /// Calcula o valor total e o valor total do iva
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public double[] GetTotaisGrelha(DataGridView dataGridView)
        {
            double[] valoresTotais = new double[2];
            double valor = 0;
            double valorIva = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Escolher"].Value is true)
                {
                    valor += Convert.ToDouble(row.Cells["Valor"].Value);
                    valorIva += Convert.ToDouble(row.Cells["Valor Iva"].Value);
                }
            }

            valoresTotais[0] = valor;
            valoresTotais[1] = valorIva;

            return valoresTotais;
        }

        /// <summary>
        ///     Limpa os valores da grelha
        /// </summary>
        public DataGridView ApagaDadosGrelha(DataGridView dataGridView)
        {
            var dt = (DataTable) dataGridView.DataSource;
            dt?.Clear();
            return dataGridView;
        }

        /// <summary>
        /// Valida se a grelha tem linhas -> Gravar documentos com
        /// pelo menos 1 linha
        /// </summary>
        public bool ValidaGrelhaNumLinhas(DataGridView dataGridView)
        {
            var counter = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Escolher"].Value is true)
                {
                    counter++;
                    counter += counter;
                }
            }

            var numLinhas = false;
            if (counter <= 0) return numLinhas;
            numLinhas = true;
            return numLinhas;

        }


        #endregion

        #region Converte Documento

        /// <summary>
        /// Converte o cabeçalho dos documentos na TDU_TRT_CabecDocumentos
        /// </summary>
        public void ConverteCabecDocumento(string documento, int ano, int numero, DateTime data, string processo)
        {
            try
            {
                var id = Guid.NewGuid();
                var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                var cotacao = $"{documento} {numero}/{ano}";
                var documentoConv = "REQ";
                var anoConv = DateTime.Now.Year;
                var numeroConv = GetDocumentosNumerador(documentoConv);

                var connectionString = GetConnectionString();
                using var sqlCon = new SqlConnection(connectionString);
                var sqlCmdLin = new SqlCommand("TDU_TRT_ConverteCabecDocumentos", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@id", id);
                sqlCmdLin.Parameters.AddWithValue("@documento", documentoConv);
                sqlCmdLin.Parameters.AddWithValue("@ano", anoConv);
                sqlCmdLin.Parameters.AddWithValue("@numero", numeroConv);
                sqlCmdLin.Parameters.AddWithValue("@documentoOrig", documento);
                sqlCmdLin.Parameters.AddWithValue("@anoOrig", ano);
                sqlCmdLin.Parameters.AddWithValue("@numeroOrig", numero);
                sqlCmdLin.Parameters.AddWithValue("@data", data);
                sqlCmdLin.Parameters.AddWithValue("@utilizador", utilizador);
                sqlCmdLin.Parameters.AddWithValue("@processo", processo);
                sqlCmdLin.Parameters.AddWithValue("@cotacao", cotacao);

                sqlCon.Open();
                sqlCmdLin.ExecuteNonQuery();
                ConverteLinhasDocumento(id, documento, numero, ano, sqlCon);
                var idProcesso = GetIdProcesso(documento, ano, numero);
                ActualizaNumProcesso(idProcesso, processo, sqlCon);
                sqlCon.Close();
                AumentaNumeradorDocumentos(documentoConv);
            }
            catch(Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao converter o documento: {ex.Message}");
            }
        }

        /// <summary>
        /// Converte as linhas dos documentos na TDU_TRT_LinhasDocumentos
        /// </summary>
        public void ConverteLinhasDocumento(Guid id, string documento, int numero, int ano, SqlConnection sqlCon)
        {
            var sqlCmdLin = new SqlCommand("TDU_TRT_ConverteLinhasDocumentos", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmdLin.Parameters.AddWithValue("@id", id);
            sqlCmdLin.Parameters.AddWithValue("@documento", documento);
            sqlCmdLin.Parameters.AddWithValue("@numero", numero);
            sqlCmdLin.Parameters.AddWithValue("@ano", ano);
            sqlCmdLin.ExecuteNonQuery();
        }

        /// <summary>
        /// Actualiza o numero do processo na TDU_TRT_Processo
        /// </summary>
        public void ActualizaNumProcesso(Guid id, string processo, SqlConnection sqlCon)
        {
            var sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaNumProcesso", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmdLin.Parameters.AddWithValue("@id", id);
            sqlCmdLin.Parameters.AddWithValue("@processo", processo);
            sqlCmdLin.ExecuteNonQuery();
        }

        #endregion

        #region Impressao

        /// <summary>
        /// Modelo de impressao dos mapas cotaçao
        /// </summary>
        /// <param name="processo"></param>
        /// <param name="documento"></param>
        public void EnviaImpressao(string documento, string numero, int ano, string docName)
        {
            var nomeMapa = string.Empty;
            if (documento == "COT")
            {
                nomeMapa = "TRT_SIM";
            }
            else
            {
                nomeMapa = "TRT_SIM";
            }

            PriEngine.Platform.Mapas.Inicializar("BAS");
            PriEngine.Platform.Mapas.Destino = StdBSTipos.CRPEExportDestino.edFicheiro;
            var list = Directory.GetFiles(@"\\192.168.10.10\primavera\SG100\Mapas\App", "*.pdf");
            var numerador = list.Length + 1;
            var fileName = string.Format("{0}_{1}_{2}_{3}.pdf", documento, ano, numero, numerador);
            PriEngine.Platform.Mapas.SetFileProp(StdBSTipos.CRPEExportFormat.efPdf, @$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
            PriEngine.Platform.Mapas.JanelaPrincipal = 0;
            PriEngine.Platform.Mapas.SelectionFormula = $"{{TDU_TRT_CabecDocumentos.CDU_Documento}} = '{documento}' AND " +
                                                        $"{{TDU_TRT_CabecDocumentos.CDU_Ano}} = {ano} AND " +
                                                        $"{{TDU_TRT_CabecDocumentos.CDU_Numero}} = {numero} ";
            PriEngine.Platform.Mapas.ImprimeListagem(nomeMapa, docName);
            System.Diagnostics.Process.Start(@$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
        }

        #endregion

        #endregion


        #region OLD
        public Guid _id { get; set; }

        #region publicos

        /// <summary>
        /// Invoca o metodo privado Cotaçao para criar uma nova cotaçao
        /// recebe a form dos serviços.
        /// </summary>
        /// <param name="frmServicos"></param>
        public void CriaCotacao(FrmServicos frmServicos)
        {
            Cotacao(frmServicos, false, "");
        }

        /// <summary>
        /// Invoca o metodo privado Requisicao para criar uma nova REQ na tabela
        /// TDU_TRT_Processos e ItemsServiço.
        /// </summary>
        /// <param name="frmServicos"></param>
        public void CriaRequisicao(FrmServicos frmServicos, bool converte, string cotacao, Guid idDoc)
        {
            Requisicao(frmServicos, converte, cotacao, idDoc);
        }

        /// <summary>
        /// Invoca o metodo privado Requisicao Adicional para criar uma nova REQ na tabela
        /// TDU_TRT_Processos e ItemsServiço.
        /// </summary>
        /// <param name="frmServicos"></param>
        public void CriaRequisicaoAdicional(FrmServicos frmServicos, bool converte, string cotacao, Guid idDoc)
        {
            RequisicaoAdicional(frmServicos, converte, cotacao, idDoc);
        }

        /// <summary>
        /// Cria o documento na Tabela TDU_TRT_CabecDocumentos e ...LinhasDocumentos
        /// </summary>
        /// <param name="frmServicos"></param>
        public void CriaDocumento(FrmServicos frmServicos, string documento, Guid idDoc)
        {
            Documentos(frmServicos, documento, idDoc);
        }

        /// <summary>
        /// Indica qual o codigo do tipo de serviço
        /// </summary>
        /// <param name="tipoServ"></param>
        /// <returns></returns>
        public string TipoServico(string tipoServ)
        {
            var strTipoServ =
                $"SELECT CDU_Codigo FROM TDU_TRT_TiposServico WHERE CDU_Nome = '{tipoServ}'";

            var lstTipoServ = PriEngine.Engine.Consulta(strTipoServ);

            if (!lstTipoServ.Vazia()) tipoServ = Convert.ToString(lstTipoServ.Valor(0));
            return tipoServ;
        }

        /// <summary>
        /// Verifica se existe um documento na tabela TDU_TRT_CabecDocumentos
        /// Se existir devolve o documento o nº e a serie.
        /// </summary>
        /// <param name="simulacao"></param>
        /// <param name="documento"></param>
        /// <returns></returns>
        public string ExisteDoc(string simulacao, string documento)
        {
            String s = simulacao;
            string strDoc;
            var lstReq = new StdBELista();
            string queryProc = String.Empty;

            if (documento == "COT")
            {
                queryProc = $"SELECT CDU_Codigo FROM TDU_TRT_Simulacao WHERE CDU_Nome = '{simulacao}'";
            }
            else if (documento == "REQ")
            {
                queryProc = $"SELECT CDU_Codigo FROM TDU_TRT_Processo WHERE CDU_NumSimulacao = '{simulacao}'";
            }
            else if (documento == "RQA")
            {
                queryProc = $"SELECT CDU_Codigo FROM TDU_TRT_Processo WHERE CDU_Codigo = '{simulacao}'";
            }

            var lstProc = PriEngine.Engine.Consulta(queryProc);

            if (!lstProc.Vazia())
            {
                if (documento != "COT")
                {
                    string numProc = lstProc.Valor(0).ToString();

                    var queryReq = "SELECT CDU_Documento, CDU_Serie, CDU_Numero " +
                                   " FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '" + documento +
                                   "' AND CDU_Processo = '" + numProc + "'";
                    lstReq = PriEngine.Engine.Consulta(queryReq);

                    if (!lstReq.Vazia())
                        strDoc = lstReq.Valor(0).ToString() + " " + lstReq.Valor(2).ToString() + "/" +
                                 lstReq.Valor(1).ToString();
                    else
                        strDoc = "vazio";

                    return strDoc;
                }
                
                strDoc = "COT" + lstProc.Valor(0).ToString();
                return strDoc;
            }

            return "vazio";
        }

        

        /// <summary>
        /// Altera o formato da data para ser compativel com o SQL
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DateTime DataSql(string data)
        {
            string formato = "MM-dd-yyyy";
            DateTime dataValidada;

            if (DateTime.TryParseExact(data, formato, null,
                DateTimeStyles.None, out dataValidada))
            {
                return dataValidada;
            }
            else
            {
                return Convert.ToDateTime(data);
            }
        }

        /// <summary>
        /// Valida se o Num. Processo é uma cotaçao ou nao
        /// </summary>
        /// <param name="processo"></param>
        /// <returns></returns>
        public bool IsCot(string processo)
        {
            String p = processo;
            if (p.Contains("COT"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SerieNumDoc(string documento)
        {
            var sqlNum = new StringBuilder();
                
            sqlNum.Append("SELECT CDU_Numerador ");
            sqlNum.Append("FROM TDU_TRT_Serie ");
            sqlNum.Append($"WHERE CDU_Documento = '{documento}' AND CDU_PreDefinido = 1 ");

            var queryNum = sqlNum.ToString();

            var lstNum = PriEngine.Engine.Consulta(queryNum);

            if (!lstNum.Vazia())
                return Convert.ToInt32(lstNum.Valor(0));
            
            return 1;
        }

        public int Ano(string documento)
        {
            var sqlNum = new StringBuilder();
            int numDoc;
                
            sqlNum.Append("SELECT CDU_Serie ");
            sqlNum.Append("FROM TDU_TRT_Serie ");
            sqlNum.Append($"WHERE CDU_Documento = '{documento}' AND CDU_PreDefinido = 1 ");

            var queryNum = sqlNum.ToString();

            var lstNum = PriEngine.Engine.Consulta(queryNum);

            if (!lstNum.Vazia()) return numDoc = Convert.ToInt32(lstNum.Valor(0));
            return numDoc = 1;
        }

        public string DevolveDocumento(string operacao)
        {
            string documento;
            
            if (operacao == "Cotação")
            {
                documento = "COT";
                return documento;
            } 
            if (operacao == "Requisição de fundos")
            {
                documento = "REQ";
                return documento;
            }
            if (operacao == "Requisição de fundos adicional")
            {
                documento = "RQA";
                return documento;
            }
            if (operacao == "Factura de Serviços")
            {
                documento = "FS";
                return documento;
            }
            
            documento = "REQ";
            return documento;
                
        }
        
        #endregion

        #region privados

        /// <summary>
        /// Metodo que cria na base de dados a cotaçao
        /// Cabecalho -> TDU_TRT_Simulacao
        /// recebe o form dos serviços
        /// </summary>
        /// <param name="frmServicos"></param>
        private void Cotacao(FrmServicos frmServicos, bool converte, string cotacao)
        {
            if (frmServicos.cbSERNumSimulacao.Text != "")
            {
                DateTime data = frmServicos.dtpSERDataDU.Value;
                DateTime dataChegada = frmServicos.dtpSERDataDU.Value;
                DateTime dataEntrada = frmServicos.dtpSERDataDU.Value;
                DateTime dataSaida = frmServicos.dtpSERDataDU.Value;
                DateTime dataDu = frmServicos.dtpSERDataDU.Value;
                Guid idDoc = Guid.NewGuid();
                int numero = SerieNumDoc(DevolveDocumento(frmServicos.cbSEROperacao.Text)) + 1;
                
                var nomeSimulacao = "COT" + numero;

                string connectionString = GetConnectionString();

                using (var sqlCon = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_InsereSimulacao", sqlCon);
                    sqlCmdLin.CommandType = CommandType.StoredProcedure;
                    sqlCmdLin.Parameters.AddWithValue("@numSimulacao", numero);
                    sqlCmdLin.Parameters.AddWithValue("@nomeSimulacao", nomeSimulacao);
                    sqlCmdLin.Parameters.AddWithValue("@Cliente", frmServicos.cbSEREntidade.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Moeda", frmServicos.cbSERMoeda.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Referencia", frmServicos.txtSERReferencia.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorCIF", frmServicos.txtSERVCIF.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorAduaneiro", frmServicos.txtSERVAduaneiro.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Cambio", frmServicos.txtSERCambio.Text);
                    sqlCmdLin.Parameters.AddWithValue("@BLCartaPorte", frmServicos.txtSERBLCartaPorte.Text);
                    sqlCmdLin.Parameters.AddWithValue("@NumVolumes", frmServicos.txtSERNumVolumes.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Peso", frmServicos.txtSERPeso.Text);
                    sqlCmdLin.Parameters.AddWithValue("@AviaoNavio", frmServicos.cbSERAviaoNavio.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Manifesto", frmServicos.txtSERManifesto.Text);
                    sqlCmdLin.Parameters.AddWithValue("@NumDAR", frmServicos.txtSERNumDAR.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorDAR", frmServicos.txtSERValorDAR.Text);
                    sqlCmdLin.Parameters.AddWithValue("@DU", frmServicos.txtSERDU.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Data", data.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataChegada", dataChegada.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataEntrada", dataEntrada.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataSaida", dataSaida.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataDU", dataDu.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DUP", frmServicos.txtSERDUP.Text);
                    sqlCmdLin.Parameters.AddWithValue("@CNCA", frmServicos.txtSERCNCA.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Operacao", frmServicos.cbSEROperacao.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Obs", frmServicos.txtSERObs.Text);
                    sqlCmdLin.Parameters.AddWithValue("@TipoMercadoria", frmServicos.txtSERTipoMercadoria.Text);
                    sqlCmdLin.Parameters.AddWithValue("@RUP", frmServicos.txtSERRUP.Text);
                    sqlCmdLin.Parameters.AddWithValue("@id", idDoc);
                    sqlCmdLin.Parameters.AddWithValue("@Documento", "COT");
                    sqlCmdLin.Parameters.AddWithValue("@Numero", numero);
                    sqlCmdLin.Parameters.AddWithValue("@Ano", DateTime.Now.Year);

                    sqlCon.Open();
                    sqlCmdLin.ExecuteNonQuery();

                    var sqlUp = new SqlCommand(
                        $"UPDATE TDU_TRT_Serie  SET CDU_Numerador = '{numero}' WHERE CDU_Documento = 'COT' " +
                        $"AND CDU_PreDefinido = 1 ", sqlCon) {Connection = sqlCon};

                    sqlUp.ExecuteNonQuery();

                    string tipoServ = TipoServico(frmServicos.cbSERCod.Text);
                    ItemsServicos(frmServicos.cbSERNumSimulacao.Text, tipoServ, frmServicos.cbSEROperacao.Text, converte, 
                        sqlCon, cotacao, idDoc);

                    sqlCon.Close();
                }
            }
        }

        /// <summary>
        /// Metodo para criar a Requisicao na base de dados
        /// </summary>
        /// <param name="frmServicos"></param>
        private void Requisicao(FrmServicos frmServicos, bool converte, string cotacao, Guid idDoc)
        {
            if (frmServicos.cbSERNumSimulacao.Text != "")
            {
                string nome = "Processo - " + frmServicos.cbSERNumSimulacao.Text;
                DateTime data = frmServicos.dtpSERDataDU.Value;
                DateTime dataChegada = frmServicos.dtpSERDataDU.Value;
                DateTime dataEntrada = frmServicos.dtpSERDataDU.Value;
                DateTime dataSaida = frmServicos.dtpSERDataDU.Value;
                DateTime dataDu = frmServicos.dtpSERDataDU.Value;
                int numero;

                if (converte is false)
                {
                    numero = SerieNumDoc(DevolveDocumento(frmServicos.cbSEROperacao.Text)) + 1;
                }
                else
                {
                    numero = SerieNumDoc(DevolveDocumento(frmServicos.cbSEROperacao.Text));
                }

                string connectionString = GetConnectionString();

                using (var sqlCon = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_InsertProcessoDirecto", sqlCon);
                    sqlCmdLin.CommandType = CommandType.StoredProcedure;
                    sqlCmdLin.Parameters.AddWithValue("@Codigo", frmServicos.cbSERNumSimulacao.Text);
                    sqlCmdLin.Parameters.AddWithValue("@nome", nome);
                    sqlCmdLin.Parameters.AddWithValue("@Cliente", frmServicos.cbSEREntidade.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Moeda", frmServicos.cbSERMoeda.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Referencia", frmServicos.txtSERReferencia.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorCIF", frmServicos.txtSERVCIF.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorAduaneiro", frmServicos.txtSERVAduaneiro.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Cambio", frmServicos.txtSERCambio.Text);
                    sqlCmdLin.Parameters.AddWithValue("@BLCartaPorte", frmServicos.txtSERBLCartaPorte.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Peso", frmServicos.txtSERPeso.Text);
                    sqlCmdLin.Parameters.AddWithValue("@AviaoNavio", frmServicos.cbSERAviaoNavio.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Manifesto", frmServicos.txtSERManifesto.Text);
                    sqlCmdLin.Parameters.AddWithValue("@NumDAR", frmServicos.txtSERNumDAR.Text);
                    sqlCmdLin.Parameters.AddWithValue("@ValorDAR", frmServicos.txtSERValorDAR.Text);
                    sqlCmdLin.Parameters.AddWithValue("@DU", frmServicos.txtSERDU.Text);
                    sqlCmdLin.Parameters.AddWithValue("@Data", data.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataChegada", dataChegada.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataEntrada", dataEntrada.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataSaida", dataSaida.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DataDU", dataDu.ToString("MM/dd/yyyy"));
                    sqlCmdLin.Parameters.AddWithValue("@DUP", frmServicos.txtSERDUP.Text);
                    sqlCmdLin.Parameters.AddWithValue("@CNCA", frmServicos.txtSERCNCA.Text);
                    sqlCmdLin.Parameters.AddWithValue("@RUP", frmServicos.txtSERRUP.Text);
                    sqlCmdLin.Parameters.AddWithValue("@NumSimulacao", cotacao);
                    sqlCmdLin.Parameters.AddWithValue("@Obs", frmServicos.txtSERObs.Text);
                    sqlCmdLin.Parameters.AddWithValue("@NumVolumes", frmServicos.txtSERNumVolumes.Text);
                    sqlCmdLin.Parameters.AddWithValue("@TipoMercadoria", frmServicos.txtSERTipoMercadoria.Text);
                    sqlCmdLin.Parameters.AddWithValue("@id", idDoc);
                    sqlCmdLin.Parameters.AddWithValue("@Documento", "REQ");
                    sqlCmdLin.Parameters.AddWithValue("@Numero", numero);
                    sqlCmdLin.Parameters.AddWithValue("@Ano", DateTime.Now.Year);
                    
                    sqlCon.Open();
                    sqlCmdLin.ExecuteNonQuery();

                    /*var sqlUp = new SqlCommand(
                        $"UPDATE TDU_TRT_Serie  SET CDU_Numerador = '{numero}' WHERE CDU_Documento = '{DevolveDocumento(frmServicos.cbSEROperacao.Text)}' " +
                        $"AND CDU_PreDefinido = 1 ", sqlCon) {Connection = sqlCon};

                    sqlUp.ExecuteNonQuery();*/

                    string tipoServ = TipoServico(frmServicos.cbSERCod.Text);
                    ItemsServicos(frmServicos.cbSERNumSimulacao.Text, tipoServ, frmServicos.cbSEROperacao.Text,
                        converte, sqlCon, cotacao, idDoc);

                    sqlCon.Close();
                }
            }
        }

        private void RequisicaoAdicional(FrmServicos frmServicos, bool converte, string cotacao, Guid idDoc)
        {
            if (frmServicos.cbSERNumSimulacao.Text != "")
            {
                var sqlNum = new StringBuilder();
                int numDoc;

                sqlNum.Append("SELECT CDU_Numerador ");
                sqlNum.Append("FROM TDU_TRT_Serie ");
                sqlNum.Append($"WHERE CDU_Documento = 'RQA' AND CDU_PreDefinido = 1 ");

                var queryNum = sqlNum.ToString();
                var lstNum = PriEngine.Engine.Consulta(queryNum);

                if (!lstNum.Vazia())
                    numDoc = Convert.ToInt32(lstNum.Valor(0)) + 1;
                else
                    numDoc = 1;

                string connectionString = GetConnectionString();

                using (var sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    
                    string tipoServ = TipoServico(frmServicos.cbSERCod.Text);
                    ItemsServicos(frmServicos.cbSERNumSimulacao.Text, tipoServ, frmServicos.cbSEROperacao.Text, converte, 
                        sqlCon, cotacao, idDoc);

                    sqlCon.Close();
                }
            }
        }

        /// <summary>
        /// Cria os documentos na APP lança na tabela TDU_TRT_CabecDocumentos e ...LinhasDocumentos
        /// </summary>
        /// <param name="frmServicos"></param>
        /// <param name="documento"></param>
        private void Documentos(FrmServicos frmServicos, string documento, Guid idDoc)
        {

            var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
            var sqlNum = new StringBuilder();
            int numDoc;

            sqlNum.Append("SELECT CDU_Numerador ");
            sqlNum.Append("FROM TDU_TRT_Serie ");
            sqlNum.Append($"WHERE CDU_Documento = '{documento}' AND CDU_PreDefinido = 1 ");

            var queryNum = sqlNum.ToString();

            var lstNum = PriEngine.Engine.Consulta(queryNum);

            if (!lstNum.Vazia())
                numDoc = Convert.ToInt32(lstNum.Valor(0)) + 1;
            else
                numDoc = 1;

            string connectionString = GetConnectionString();

            using (var sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                using (var transaction = sqlCon.BeginTransaction())
                {
                    var sqlCmd = new SqlCommand("TDU_TRT_InsertCabecDoc", sqlCon)
                    {
                        Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                    };

                    DateTime dataDoc = DataSql(frmServicos.dtpSERData.Text);
                    DateTime dataCria = DataSql(DateTime.Now.Date.ToString());

                    sqlCmd.Parameters.AddWithValue("@id", idDoc);
                    sqlCmd.Parameters.AddWithValue("@documento", documento);
                    sqlCmd.Parameters.AddWithValue("@serie", DateTime.Now.Year.ToString());
                    sqlCmd.Parameters.AddWithValue("@numDoc", numDoc);
                    sqlCmd.Parameters.AddWithValue("@dataDoc", dataDoc);
                    sqlCmd.Parameters.AddWithValue("@dataCria", dataCria);
                    sqlCmd.Parameters.AddWithValue("@processo", frmServicos.cbSERNumSimulacao.Text);
                    sqlCmd.Parameters.AddWithValue("@utilizador", utilizador);
                    sqlCmd.ExecuteNonQuery();

                    var sqlUp = new SqlCommand(
                        $"UPDATE TDU_TRT_Serie  SET CDU_Numerador = '{numDoc}' WHERE CDU_Documento = '{documento}' " +
                        $"AND CDU_PreDefinido = 1 ", sqlCon) {Connection = sqlCon, Transaction = transaction};

                    sqlUp.ExecuteNonQuery();
                    LinhasDocumentos(frmServicos.cbSERNumSimulacao.Text, idDoc, sqlCon, transaction);
                    transaction.Commit();
                    transaction.Dispose();
                }

                sqlCon.Close();
                
            }

            //Imprime = true;
        }

        /// <summary>
        /// Cria as linhas das cotaçoes e ou simulacoes na tabela TDU_TRT_ItemsServicos
        /// </summary>
        /// <param name="processo"></param>
        /// <param name="tipoServ"></param>
        /// <param name="operacao"></param>
        private void ItemsServicos(string processo, string tipoServ, string operacao, bool converte, 
            SqlConnection sqlCon, string cotacao, Guid idDoc)
        {
            var sql = new StringBuilder();
            string likeTipoServ = "%" + tipoServ + "%";

            if (converte is false)
            {
                sql.Append($"INSERT INTO [dbo].[TDU_TRT_ItemsServicos] ");
                sql.Append("([CDU_Id] ");
                sql.Append(",[CDU_Items] ");
                sql.Append(",[CDU_TipoServ] ");
                sql.Append(",[CDU_Operacao] ");
                sql.Append(",[CDU_Processo] ");
                sql.Append(",[CDU_idDoc]) ");
                sql.Append($" SELECT NewId(), CDU_Nome, '{tipoServ}', '{operacao}', '{processo}', '{idDoc}' ");
                sql.Append($"FROM TDU_TRT_Items WHERE CDU_TipoServ LIKE '{likeTipoServ}'");
                sql.Append("Order By CDU_Posicao");

                var query = sql.ToString();

                PriEngine.Engine.DSO.ExecuteSQL(query);
            }
            else
            {
                var sqlCmdLin = new SqlCommand("TDU_TRT_ConverteItemsServicos", sqlCon)
                {
                    Connection = sqlCon, CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@Cotacao", cotacao);
                sqlCmdLin.Parameters.AddWithValue("@Processo", processo);
                sqlCmdLin.Parameters.AddWithValue("@IdDoc", idDoc);
                sqlCmdLin.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Cria as linhas dos documentos da App TDU_TRT_LinhasDocumentos
        /// </summary>
        /// <param name="cotacao"></param>
        /// <param name="sqlCon"></param>
        /// <param name="transaction"></param>
        private void LinhasDocumentos(string nProcesso, Guid idDoc, SqlConnection sqlCon, SqlTransaction transaction)
        {
            var sql = new StringBuilder();
            var i = 1;

            sql.Append("SELECT I.CDU_CodPrimavera, I.CDU_IVA, S.CDU_ValoresSimulacao, S.CDU_IvaSimulacao ");
            sql.Append("FROM TDU_TRT_ItemsServicos S ");
            sql.Append("INNER JOIN TDU_TRT_Items I ");
            sql.Append("ON S.CDU_Items = I.CDU_Nome ");
            sql.Append($"WHERE S.CDU_Processo = '{nProcesso}' ");
            sql.Append("AND S.CDU_ValoresSimulacao > 0 ");

            var query = sql.ToString();

            var lstLinhas = PriEngine.Engine.Consulta(query);

            if (lstLinhas.Vazia()) return;
            while (!lstLinhas.NoFim())
            {
                string artigo = lstLinhas.Valor(0).ToString();
                string iva = lstLinhas.Valor(1).ToString();
                double precUnit = lstLinhas.Valor(2);
                double precIva = lstLinhas.Valor(3);
                var total = precUnit + precIva;

                var sqlCmdLin = new SqlCommand("TDU_TRT_InsertLinhasDoc", sqlCon)
                {
                    Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@id", idDoc);
                sqlCmdLin.Parameters.AddWithValue("@i", i);
                sqlCmdLin.Parameters.AddWithValue("@artigo", artigo);
                sqlCmdLin.Parameters.AddWithValue("@iva", iva);
                sqlCmdLin.Parameters.AddWithValue("@precUnit", precUnit);
                sqlCmdLin.Parameters.AddWithValue("@precIVA", precIva);
                sqlCmdLin.Parameters.AddWithValue("@total", total);
                sqlCmdLin.ExecuteNonQuery();

                lstLinhas.Seguinte();
                i += 1;
            }
        }

        #endregion
    }

    #endregion

}
