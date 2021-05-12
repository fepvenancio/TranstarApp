using StdBE100;
using StdPlatBS100;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TRTv10.Engine;

namespace TRTv10.Integration
{
    class Motores
    {
        #region Variaveis

        private Guid _idProcesso;
        private Guid _idDocumento;
        private string Documento;

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
        public void CriaDocumentos(string codigo, string descricao, int numerador, int ano, int numVias,
            bool preVisualiza,
            bool exportaPrimavera, string codPrimavera, string natureza, string posicao, string tipoServ)
        {
            var connectionString = GetConnectionString();

            using var sqlCon = new SqlConnection(connectionString);
            SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_InsereDocumentos", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
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
            double valorAduaneiro, double cambio, string cnca, string dup, string blCartaPorte, string rup,
            string referencia, DateTime data,
            DateTime dataChegada, string tipoMercadoria, string obs, string transporte, string manifesto, string numDar,
            string valorDar,
            string du, string numVolumes, DateTime dataEntrada, DateTime dataSaida, DateTime dataDu, double peso)
        {
            _idProcesso = Guid.NewGuid();

            var connectionString = GetConnectionString();
            using var sqlCon = new SqlConnection(connectionString);
            var sqlCmdLin = new SqlCommand("TDU_TRT_CriaProcesso", sqlCon) {CommandType = CommandType.StoredProcedure};
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
        /// Vai ao cabec e actualiza todos os processos com o IdDRV
        /// </summary>
        /// <param name="processo"></param>
        private void UpdateDRVProcesso(string processo, Guid idDrv)
        {
            var query = $"UPDATE L SET CDU_IdDrv = '{idDrv}' FROM TDU_TRT_LinhasDocumentos L INNER JOIN TDU_TRT_CabecDocumentos C ON C.CDU_Id = L.CDU_idDoc  WHERE CDU_Processo = '{processo}'";

            var connectionString = GetConnectionString();
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            command.CommandText = query;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Verifica qual a linha da REQ ou RQA e actualiza a campo CDU_idRi
        /// </summary>
        /// <param name="processo"></param>
        private void UpdateRiProcesso(Guid idRi, Guid idReq, string item)
        {
            var queryIdLin = $"SELECT CDU_id FROM TDU_TRT_LinhasDocumentos WHERE CDU_idDoc = '{idReq}' AND CDU_Item = '{item}' ";
            var lstIdLin = PriEngine.Engine.Consulta(queryIdLin);
            if(lstIdLin.Vazia() || lstIdLin.NoFim()) return;
            var idLinha = lstIdLin.Valor(0);
            var query = $"UPDATE TDU_TRT_LinhasDocumentos SET CDU_IdRi = '{idRi}' WHERE CDU_Id = '{idLinha}'";
            var connectionString = GetConnectionString();
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            command.CommandText = query;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

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
            string codPostal, string codPostalLocalidade, string pais, bool ivaCativo, bool retencao,
            DataGridView dataGridView)
        {
            if (documento == "DRV")
            {
                var motores = new Motores();
                _idProcesso = motores.GetIdProcessoByProcesso(processo);
                UpdateDRVProcesso(processo, idOrig);
            }

            if (documento == "RI")
            {
                var motores = new Motores();
                _idProcesso = motores.GetIdProcessoByProcesso(processo);
                Documento = "RI";
            }

            var connectionString = GetConnectionString();
            using var sqlCon = new SqlConnection(connectionString);
            var sqlCmdLin = new SqlCommand("TDU_TRT_CriaCabecDocumentos", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
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
            if (documento == "ND" || documento == "FA" || documento == "FR" || documento == "FAT" || documento == "NC")
            {
                CriaLinhasDocumentoDrv(idOrig, dataGridView, sqlCon, documento);
            }
            else
            {
                CriaLinhasDocumento(idOrig, dataGridView, sqlCon);
            }
            sqlCon.Close();
            AumentaNumeradorDocumentos(documento);

            if (documento == "DRV" || documento == "COT" || documento == "RI") return;
            var integraPrimavera = new IntegraPrimavera();
            integraPrimavera.IntegraDocVendasErpPrimavera(documento, cliente, data, cambio,
                Convert.ToString(ano), processo, retencao, numero);
        }

        public void CriaCabecDocumentoRi(Guid idOrig, string documento, int ano, int numero, DateTime data, string moeda,
            double cambio, string observacoes, string processo, string cotacao, string tipoServ,
            double valorDoc, double valorIva, double valorRet, double valorTot, double valorRec,
            string utilizador, string cliente, string nome, string nif, string morada, string localidade,
            string codPostal, string codPostalLocalidade, string pais, bool ivaCativo, bool retencao,
            DataGridView dataGridView, string docOriginal, int anoOriginal, int numOriginal)
        {
            _idProcesso = GetIdProcessoByProcesso(processo);
            Documento = "RI";

            var connectionString = GetConnectionString();
            using var sqlCon = new SqlConnection(connectionString);
            var sqlCmdLin = new SqlCommand("TDU_TRT_CriaCabecDocumentos", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
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
            
            var idReq = GetIdDocumento(docOriginal, anoOriginal, numOriginal);
            CriaLinhasDocumentoRi(idOrig, dataGridView, sqlCon, idReq);
            
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
            SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaCabecDocumentos", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
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
                var id = Guid.NewGuid();
                if (!(row.Cells["Escolher"].Value is true)) continue;
                var item = Convert.ToString(row.Cells["Item"].Value);
                var valor = Convert.ToDouble(row.Cells["Valor"].Value);
                var valorIva = Convert.ToDouble(row.Cells["Valor Iva"].Value);

                SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_CriaLinhasDoc", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
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

        public void CriaLinhasDocumentoRi(Guid idDoc, DataGridView dataGridView, SqlConnection sqlCon, Guid idReq)
        {
            var i = 1;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var id = Guid.NewGuid();
                if (!(row.Cells["Escolher"].Value is true)) continue;
                var item = Convert.ToString(row.Cells["Item"].Value);
                var valor = Convert.ToDouble(row.Cells["Valor"].Value);
                var valorIva = Convert.ToDouble(row.Cells["Valor Iva"].Value);

                SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_CriaLinhasDoc", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
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

                if(Documento == "RI")
                {
                    UpdateRiProcesso(idDoc, idReq, item);
                }
            }
        }

        public void CriaLinhasDocumentoDrv(Guid idDoc, DataGridView dataGridView, SqlConnection sqlCon, string documento)
        {
            var i = 1;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var id = Guid.NewGuid();
                if (!(row.Cells["Escolher"].Value is true)) continue;
                var item = Convert.ToString(row.Cells["Item"].Value);
                var valor = Convert.ToDouble(row.Cells["Valor"].Value);
                var valorIva = Convert.ToDouble(row.Cells["Valor Iva"].Value);
                var linhaDoc = GetDocumentoACriarDrv(item);

                if (linhaDoc != documento) continue;
                var sqlCmdLin = new SqlCommand("TDU_TRT_CriaLinhasDoc", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
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

        public void ActualizaLinhasDocumento(string documento, int ano, int numero, DateTime data, string moeda,
            double cambio, string observacoes, string processo, string cotacao, string tipoServ,
            double valorDoc, double valorIva, double valorRet, double valorTot, double valorRec,
            string utilizador, string cliente, string nome, string nif, string morada, string localidade,
            string codPostal, string codPostalLocalidade, string pais, bool ivaCativo, bool retencao)
        {
            var connectionString = GetConnectionString();
            Guid id = Guid.Empty;

            using var sqlCon = new SqlConnection(connectionString);
            SqlCommand sqlCmdLin = new SqlCommand("TDU_TRT_InsereDocumentos", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
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

        public void ActualizaIdDrvLinhasDoc(Guid id, string documento, int ano, int numero)
        {
            try
            {
                var connectionString = GetConnectionString();
                using var sqlCon = new SqlConnection(connectionString);
                var sqlCmdLin = new SqlCommand("TDU_TRT_ActualizaLinhasDocumentosIdDrv ", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@idDrv", id);
                sqlCmdLin.Parameters.AddWithValue("@documento", documento);
                sqlCmdLin.Parameters.AddWithValue("@numero", numero);
                sqlCmdLin.Parameters.AddWithValue("@ano", ano);

                sqlCon.Open();
                sqlCmdLin.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao actualizar a DRV na linha: {ex.Message}");
            }
        }

        #endregion

        #region Combo Box

        /// <summary>
        /// Vai buscar o nome do Cliente
        /// </summary>
        /// <param name="codCliente"></param>
        /// <returns></returns>
        public ComboBox GetProcessoCliente(ComboBox cbComboBox, string codCliente)
        {
            var sql = new StringBuilder();

            sql.Append("SELECT CDU_Processo ");
            sql.Append($"FROM TDU_TRT_Processo WHERE CDU_Cliente = '{codCliente}' ");
            sql.Append("AND CDU_Processo not like 'COT%' ");

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
            sql.Append("SELECT DISTINCT (CDU_Processo) ");
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


        /// <summary>
        /// Verifica na BD o Id do documento passado nos parametros
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="ano"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public Guid GetIdDocumento(string documento, int ano, int num)
        {
            var query = $"SELECT CDU_id FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '{documento}' AND CDU_Ano = '{ano}' AND CDU_Numero = '{num}' " ;
            var lstQ = PriEngine.Engine.Consulta(query);
            var idDoc = lstQ.Valor(0);
            return idDoc;
        }

        /// <summary>
        /// Altera virgulas por pontos
        /// </summary>
        public double AlteraPontosPorVirgulas(string cambio)
        {
            cambio = cambio.Replace(",", ".");
            CultureInfo culture = CultureInfo.InvariantCulture;
            double valorCambio = Convert.ToDouble(cambio, culture);
            return valorCambio;
        }

        /// <summary>
        /// Valida se existem pontos a separar casas decimais de um numero
        /// </summary>
        /// <param name="cambio"></param>
        /// Cambio em texto para validar se existem pontos como separador decimal
        /// <returns></returns>
        /// devolve um boolean verdadeiro caso hajam pontos falso se estiver correcto
        public bool NumerosComPontosNasCasasDecimais(string cambio)
        {
            if (!cambio.Contains(".")) return false;
            return true;
        }


        private static DataGridView GetDocumentos(DataGridView dataGridView, string cliente, string processo, 
            bool contaFechada, DateTime dataInicial, DateTime dataFinal)
        {
            //string[] formats = {"MM/dd/yyyy"};
            //var dataIni = DateTime.ParseExact(dataInicial, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            //var dataFim = DateTime.ParseExact(dataFinal, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            var dataIni = $"{dataInicial:MM/dd/yyyy}";
            var dataFim = $"{dataFinal:MM/dd/yyyy}";

            var linhasQ = new StringBuilder();
            linhasQ.Append("SELECT C.CDU_Processo, C.CDU_Cliente, C.CDU_Documento, C.CDU_Numero, C.CDU_Ano, ");
            linhasQ.Append("CASE WHEN D.CDU_Natureza = 'D' THEN C.CDU_ValorTot ELSE ");
            linhasQ.Append("CASE WHEN C.CDU_Documento = 'FR' THEN C.CDU_ValorTot ELSE 0 END END As 'Debito',");
            linhasQ.Append("CASE WHEN D.CDU_Natureza = 'C' THEN C.CDU_ValorTot ELSE 0 END As 'Credito' ");
            linhasQ.Append("FROM TDU_TRT_CabecDocumentos C ");
            linhasQ.Append("INNER JOIN TDU_TRT_Documento D ");
            linhasQ.Append("ON C.CDU_Documento = D.CDU_Codigo ");
            linhasQ.Append("WHERE CDU_Codigo <> 'COT' ");
            linhasQ.Append("AND CDU_Codigo <> 'DRV' ");
            linhasQ.Append("AND CDU_Codigo <> 'RI' ");

            if (contaFechada is true)
            {
                linhasQ.Append("AND CDU_Codigo <> 'REQ' ");
                linhasQ.Append("AND CDU_Codigo <> 'RQA' ");
            
            }
            else
            {
                linhasQ.Append("AND CDU_Codigo <> 'RCF' ");
            }

            if (processo != "")
            {
                linhasQ.Append($"AND C.CDU_Processo = '{processo}' ");
            }
            else
            {
                    linhasQ.Append($"AND C.CDU_Cliente = '{cliente}' ");
                    linhasQ.Append($"AND C.CDU_Data >= '{dataIni}' ");
                    linhasQ.Append($"AND C.CDU_Data <= '{dataFim}' ");
            }

            //linhasQ.Append("ORDER BY C.CDU_Processo, C.CDU_Data");

            var qDocs = linhasQ.ToString();
            var lstQ = PriEngine.Engine.Consulta(qDocs);
            var tabela = new DataTable();
            double debito;
            double credito;
            double saldoProcesso = 0;
            double saldoAcum = 0;

            tabela.Columns.Add("Processo", typeof(string));
            tabela.Columns.Add("Cliente", typeof(string));
            tabela.Columns.Add("Documento", typeof(string));
            tabela.Columns.Add("Número", typeof(string));
            tabela.Columns.Add("Ano", typeof(string));
            tabela.Columns.Add("Débito", typeof(double));
            tabela.Columns.Add("Crédito", typeof(double));
            tabela.Columns.Add("Saldo Processo", typeof(double));
            tabela.Columns.Add("Saldo Acumulado", typeof(double));

            if (!lstQ.Vazia())
            {
                processo = lstQ.Valor(0);
                while (!lstQ.NoFim())
                {
                    string processoLin = lstQ.Valor(0);
                    cliente = lstQ.Valor(1);
                    string documento = lstQ.Valor(2);
                    string numero = lstQ.Valor(3).ToString();
                    string ano = lstQ.Valor(4).ToString();
                    debito = lstQ.Valor(5);
                    credito = lstQ.Valor(6);
                    if (processo == processoLin)
                    {
                        saldoProcesso += debito - credito;
                    }
                    else
                    {
                        //var totalDebito = Convert.ToDecimal(tabela.Compute("SUM(Débito)", processo)); 
                        //var totalCredito = Convert.ToDecimal(tabela.Compute("SUM(Crédito)", processo));
                        //tabela.Rows.Add("", "", "", "", "Total Processo", totalDebito, totalCredito);
                        tabela.Rows.Add();
                        processo = lstQ.Valor(0);
                        saldoProcesso = debito - credito;
                    }

                    saldoAcum += debito - credito;
                    tabela.Rows.Add(processo, cliente, documento, numero, ano, debito, credito, saldoProcesso, saldoAcum);
                    lstQ.Seguinte();
                }
            }
        
            try
            {
                
                var totalDebito = Convert.ToDecimal(tabela.Compute("SUM(Débito)", string.Empty)); 
                var totalCredito = Convert.ToDecimal(tabela.Compute("SUM(Crédito)", string.Empty));
                tabela.Rows.Add("", "", "", "", "Total", totalDebito, totalCredito);
                tabela.Rows.Add();

                dataGridView.DataSource = tabela;
                dataGridView.Columns["Processo"].Width = 150;
                dataGridView.Columns["Processo"].ReadOnly = true;
                dataGridView.Columns["Cliente"].Width = 150;
                dataGridView.Columns["Cliente"].ReadOnly = true;
                dataGridView.Columns["Documento"].Width = 100;
                dataGridView.Columns["Documento"].ReadOnly = true;
                dataGridView.Columns["Número"].Width = 75;
                dataGridView.Columns["Número"].ReadOnly = true;
                dataGridView.Columns["Ano"].Width = 50;
                dataGridView.Columns["Ano"].ReadOnly = true;
                dataGridView.Columns["Débito"].Width = 150;
                dataGridView.Columns["Débito"].ReadOnly = true;
                dataGridView.Columns["Crédito"].Width = 150;
                dataGridView.Columns["Crédito"].ReadOnly = true;
                dataGridView.Columns["Saldo Processo"].Width = 150;
                dataGridView.Columns["Saldo Processo"].ReadOnly = true;
                dataGridView.Columns["Saldo Acumulado"].Width = 150;
                dataGridView.Columns["Saldo Acumulado"].ReadOnly = true;
            }
            catch(Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar a lista de documentos: {ex.Message}");
            }

            return dataGridView;
        }

        private static DataGridView GetDocumentosRecebimentos(DataGridView dataGridView, string processo)
        {
            //string[] formats = {"MM/dd/yyyy"};
            //var dataIni = $"{dataInicial:MM/dd/yyyy}";
            //var dataFim = $"{dataFinal:MM/dd/yyyy}";

            var linhasQ = new StringBuilder();
            linhasQ.Append("SELECT CDU_Documento, CDU_Ano, CDU_Numero, CDU_Data, CDU_Moeda, ");
            linhasQ.Append("CDU_ValorTot, CDU_ValorRet, CDU_ValorRec, CDU_ValorPend ");
            linhasQ.Append("FROM TDU_TRT_CabecDocumentos ");
            linhasQ.Append($"WHERE CDU_Processo = '{processo}' ");
            linhasQ.Append("AND CDU_ValorTot > CDU_ValorPend ");
            linhasQ.Append("AND CDU_Documento <> 'RI' ");
            linhasQ.Append("AND CDU_Documento <> 'DRV' ");
            linhasQ.Append("AND CDU_Documento <> 'RCF' ");
            linhasQ.Append("AND CDU_Documento <> 'REQ' ");
            linhasQ.Append("AND CDU_Documento <> 'RQA' ");
            linhasQ.Append("AND CDU_Documento <> 'RE' ");
            linhasQ.Append("AND CDU_Documento <> 'COT' ");

            var qDocs = linhasQ.ToString();
            var lstQ = PriEngine.Engine.Consulta(qDocs);
            var tabela = new DataTable();

            tabela.Columns.Add("Documento", typeof(string));
            tabela.Columns.Add("Ano", typeof(string));
            tabela.Columns.Add("Número", typeof(string));
            tabela.Columns.Add("Data", typeof(string));
            tabela.Columns.Add("Moeda", typeof(string));
            tabela.Columns.Add("Valor Doc.", typeof(double));
            tabela.Columns.Add("Valor Ret.", typeof(double));
            tabela.Columns.Add("Valor Pend.", typeof(double));
            tabela.Columns.Add("Valor Rec.", typeof(double));

            if (!lstQ.Vazia())
            {
                while (!lstQ.NoFim())
                {
                    string documento = lstQ.Valor(0);
                    int ano = lstQ.Valor(1);
                    int numero = lstQ.Valor(2);
                    string data = lstQ.Valor(3).ToString();
                    string moeda = lstQ.Valor(4).ToString();
                    var valorTot = lstQ.Valor(5);
                    var valorRet = lstQ.Valor(6);
                    var valorRec  = lstQ.Valor(7);
                    var valorPend = lstQ.Valor(8);
                    
                    tabela.Rows.Add(documento, ano, numero, data, moeda, valorTot, valorRet, valorRec, valorPend);
                    lstQ.Seguinte();
                }
            }
        
            try
            {
                dataGridView.DataSource = tabela;
                dataGridView.Columns["Documento"].Width = 150;
                dataGridView.Columns["Documento"].ReadOnly = true;
                dataGridView.Columns["Ano"].Width = 150;
                dataGridView.Columns["Ano"].ReadOnly = true;
                dataGridView.Columns["Número"].Width = 100;
                dataGridView.Columns["Número"].ReadOnly = true;
                dataGridView.Columns["Data"].Width = 85;
                dataGridView.Columns["Data"].ReadOnly = true;
                dataGridView.Columns["Moeda"].Width = 100;
                dataGridView.Columns["Moeda"].ReadOnly = true;
                dataGridView.Columns["Valor Doc."].Width = 150;
                dataGridView.Columns["Valor Doc."].ReadOnly = true;
                dataGridView.Columns["Valor Ret."].Width = 150;
                dataGridView.Columns["Valor Ret."].ReadOnly = true;
                dataGridView.Columns["Valor Pend."].Width = 150;
                dataGridView.Columns["Valor Pend."].ReadOnly = true;
                dataGridView.Columns["Valor Rec."].Width = 150;
                dataGridView.Columns["Valor Rec."].ReadOnly = false;
            }
            catch(Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao carregar a lista de documentos: {ex.Message}");
            }

            return dataGridView;
        }

        /// <summary>
        /// Valida se ja existe uma DRV para o processo
        /// </summary>
        /// <param name="processo"></param>
        /// <returns></returns>
        public bool GetDrvProcesso(string processo)
        {
            var sqlNDocs = new StringBuilder();
            sqlNDocs.Append("SELECT CDU_Documento, CDU_Numero, CDU_Ano ");
            sqlNDocs.Append("FROM TDU_TRT_CabecDocumentos ");
            sqlNDocs.Append($"WHERE CDU_Processo = '{processo}' ");
            sqlNDocs.Append($"AND CDU_Documento = 'DRV' ");
            var queryNDocs = sqlNDocs.ToString();
            var lstNDocs = PriEngine.Engine.Consulta(queryNDocs);
            return !lstNDocs.Vazia() && !lstNDocs.NoFim();
        }

        /// <summary>
        /// Devolve o numero/ano da DRV na BD para determinado processo
        /// </summary>
        /// <param name="processo"></param>
        /// <returns></returns>
        public string[] GetNumAnoDrvProcesso(string processo)
        {
            var sqlNDocs = new StringBuilder();
            sqlNDocs.Append("SELECT CDU_Documento, CDU_Numero, CDU_Ano ");
            sqlNDocs.Append("FROM TDU_TRT_CabecDocumentos ");
            sqlNDocs.Append($"WHERE CDU_Processo = '{processo}' ");
            sqlNDocs.Append($"AND CDU_Documento = 'DRV' ");
            var queryNDocs = sqlNDocs.ToString();
            var lstNDocs = PriEngine.Engine.Consulta(queryNDocs);
            var arrDoc = new string[2];

            if(!lstNDocs.Vazia() && !lstNDocs.NoFim())
            {
                arrDoc[0] = Convert.ToString(lstNDocs.Valor(1));
                arrDoc[1] = Convert.ToString(lstNDocs.Valor(2));
            }

            return arrDoc;
        }


        public string GetDocumentoACriarDrv(string descricao)
        {
            var query =
                $"SELECT CDU_DocPrimavera FROM TDU_TRT_Items WHERE CDU_Nome = '{descricao}'";
            var lstQ = PriEngine.Engine.Consulta(query);
            if (lstQ.Vazia() || lstQ.NoFim()) return "0";
            return lstQ.Valor(0).ToString();
        }

        public string[] GetDocumentosCriarPItem(string documento, int numero, int ano)
        {
            var sqlNDocs = new StringBuilder();
            sqlNDocs.Append("SELECT Count(DISTINCT(I.CDU_DocPrimavera)) ");
            sqlNDocs.Append("FROM TDU_TRT_CabecDocumentos C ");
            sqlNDocs.Append("INNER JOIN TDU_TRT_LinhasDocumentos L ");
            sqlNDocs.Append("ON C.CDU_Id = L.CDU_IdDoc ");
            sqlNDocs.Append("INNER JOIN TDU_TRT_Items I ");
            sqlNDocs.Append("ON I.CDU_Nome = L.CDU_Item ");
            sqlNDocs.Append($"WHERE C.CDU_Documento = '{documento}' ");
            sqlNDocs.Append($"AND C.CDU_Numero = {numero} ");
            sqlNDocs.Append($"AND C.CDU_Ano = {ano} ");
            var queryNDocs = sqlNDocs.ToString();
            var lstNDocs = PriEngine.Engine.Consulta(queryNDocs);
            var numArr = 0;

            if (!lstNDocs.Vazia() || lstNDocs.NoFim())
            {
                numArr = lstNDocs.Valor(0);
            }

            var arrDocs = new string[numArr];
            if (numArr >= 1)
            {
                var sqlQ = new StringBuilder();
                sqlQ.Append("SELECT DISTINCT(I.CDU_DocPrimavera) ");
                sqlQ.Append("FROM TDU_TRT_CabecDocumentos C ");
                sqlQ.Append("INNER JOIN TDU_TRT_LinhasDocumentos L ");
                sqlQ.Append("ON C.CDU_Id = L.CDU_IdDoc ");
                sqlQ.Append("INNER JOIN TDU_TRT_Items I ");
                sqlQ.Append("ON I.CDU_Nome = L.CDU_Item ");
                sqlQ.Append($"WHERE C.CDU_Documento = '{documento}' ");
                sqlQ.Append($"AND C.CDU_Numero = {numero} ");
                sqlQ.Append($"AND C.CDU_Ano = {ano} ");
                var query = sqlQ.ToString();
                var lstQ = PriEngine.Engine.Consulta(query);

                var i = 0;
                if (!lstQ.Vazia() || lstQ.NoFim())
                {
                    while (!lstQ.NoFim())
                    {
                        arrDocs[i] = lstQ.Valor(0);
                        lstQ.Seguinte();
                        i++;
                    }
                }
            }

            return arrDocs;
        }

        public bool ValidaRequisicaoProcessoExiste(string processo)
        {
            var query =
                $"SELECT CDU_Documento FROM TDU_TRT_CabecDocumentos WHERE CDU_Processo = '{processo}' AND CDU_Documento = 'REQ'";
            var lstQ = PriEngine.Engine.Consulta(query);
            if (!lstQ.Vazia() || !lstQ.NoFim())
            {
                return true;
            }

            return false;
        }

        public string GetReqDocumentoNumAno(string documento, int ano, int numero)
        {
            string doc = "false";
            var cotacao = $"{documento} {numero}/{ano}";
            var query =
                $"SELECT CDU_Documento, CDU_Numero, CDU_Ano FROM TDU_TRT_CabecDocumentos WHERE CDU_Cotacao = '{cotacao}' AND CDU_Documento = 'REQ'";
            var lstQ = PriEngine.Engine.Consulta(query);
            if (!lstQ.Vazia() || !lstQ.NoFim())
            {
                doc = lstQ.Valor(0).ToString() + " " + lstQ.Valor(1).ToString() + "/" + lstQ.Valor(2).ToString();
            }

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
            var query = $"SELECT CDU_Cotacao FROM TDU_TRT_CabecDocumentos WHERE CDU_Cotacao = '{cotacao}' AND CDU_Documento = 'REQ'";
            var lstQ = PriEngine.Engine.Consulta(query);
            return !lstQ.Vazia() || !lstQ.NoFim();
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
        /// Devolve o id do processo baseado no documento usado para criar o processo
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="ano"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public Guid GetIdProcessoByProcesso(string processo)
        {
            var q = new StringBuilder();
            q.Append("SELECT CDU_Id ");
            q.Append("FROM TDU_TRT_Processo ");
            q.Append($"WHERE CDU_Processo = '{processo}' ");
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
            var query =
                $"SELECT CDU_Id FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '{documento}' AND CDU_Numero = {numero} AND CDU_Ano = {ano}";
            var lstQ = PriEngine.Engine.Consulta(query);
            if (!lstQ.Vazia() || !lstQ.NoFim())
            {
                return true;
            }
            else
            {
                return false;
            }
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
            sql.Append(",C.CDU_ValorDoc, C.CDU_ValorIva, C.CDU_ValorRet, C.CDU_ValorTot, P.CDU_Processo "); //29
            sql.Append("FROM dbo.TDU_TRT_Processo P ");
            sql.Append("INNER JOIN dbo.TDU_TRT_CabecDocumentos C ");
            sql.Append("ON C.CDU_IdProcesso = P.CDU_id ");
            sql.Append($"WHERE C.CDU_Documento = '{documento}' AND C.CDU_Ano = {ano} AND C.CDU_Numero = {numero} ");

            var query = sql.ToString();
            var lstDados = PriEngine.Engine.Consulta(query);
            return lstDados;
        }

        public StdBELista GetDadosFormRi(string documento, int numero, int ano)
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
            sql.Append($"AND L.CDU_idRi is null ");

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
            var query =
                $"SELECT CDU_id FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '{documento}' AND CDU_Numero = {numero} " +
                $"AND CDU_Ano = {ano}";
            var lstQ = PriEngine.Engine.Consulta(query);

            if (!lstQ.Vazia())
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
        public DataGridView GetItems(DataGridView dataGridView, bool existeDoc, string documento)
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
                if (documento == "DRV")
                {
                    Guid idDrv = _idDocumento;
                    qItems = "SELECT CDU_Item, CDU_PrecUnit, CDU_PrecIVA FROM TDU_TRT_LinhasDocumentos " +
                             $"WHERE CDU_IdDoc = '{idDrv}' " +
                             "AND CDU_IdDrv is null";
                }
                else if (documento == "RI")
                {
                    qItems = "SELECT CDU_Item, CDU_PrecUnit, CDU_PrecIVA FROM TDU_TRT_LinhasDocumentos " +
                             $"WHERE CDU_IdDoc = '{_idDocumento}' " +
                             "AND CDU_IdRi is null";
                }
                else
                {
                    qItems =
                        $"SELECT CDU_Item, CDU_PrecUnit, CDU_PrecIVA FROM TDU_TRT_LinhasDocumentos WHERE CDU_IdDoc = '{_idDocumento}'";
                }

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
        public DataGridView PopulaGrelhaLinhasDoc(DataGridView dataGridView, string documento, int numero, int ano)
        {
            var existeDoc = GetExisteDoc(documento, numero, ano);
            GetItems(dataGridView, existeDoc, documento);
            return dataGridView;
        }

        public DataGridView PopulaGrelhaLinhasDocRi(DataGridView dataGridView, string documento, int numero, int ano)
        {
            var existeDoc = GetExisteDoc(documento, numero, ano);
            GetItems(dataGridView, existeDoc, "RI");
            return dataGridView;
        }

        /// <summary>
        /// Le e carrega os items para a grelha
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="documento"></param>
        /// <param name="numero"></param>
        /// <param name="dataInicial"></param>
        /// <param name="dataFinal"></param>
        /// <returns></returns>
        public DataGridView PopulaGrelhaExtDocumentos(DataGridView dataGridView, string cliente, string processo, 
            bool contaFechada, DateTime dataInicial, DateTime dataFinal)
        {
            GetDocumentos(dataGridView, cliente, processo, contaFechada, dataInicial, dataFinal);
            return dataGridView;
        }

        public DataGridView PopulaGrelhaLinhasRecebimentos(DataGridView dataGridView, string processo)
        {
            GetDocumentosRecebimentos(dataGridView, processo);
            return dataGridView;
        }

        /// <summary>
        /// Calcula o valor total e o valor total do iva
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public double[] GetTotaisGrelha(DataGridView dataGridView)
        {
            var valoresTotais = new double[2];
            double valor = 0;
            double valorIva = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Escolher"].Value is true)
                {
                    var valorP = AlteraPontosPorVirgulas(row.Cells["Valor"].Value.ToString());
                    valor += valorP;
                    var valorI = AlteraPontosPorVirgulas(row.Cells["Valor Iva"].Value.ToString());
                    valorIva += valorI;
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
        public void ConverteCabecDocumento(string documentoConv, string documento, int ano, int numero, DateTime data,
            string processo)
        {
            try
            {
                var id = Guid.NewGuid();
                var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                var cotacao = $"{documento} {numero}/{ano}";
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

                if (documentoConv == "DRV")
                {
                    ActualizaIdDrvLinhasDoc(id, documento, ano, numero);
                }

                sqlCon.Close();
                AumentaNumeradorDocumentos(documentoConv);

                if (documento == "DRV") return;
                var qDoc = "SELECT CDU_Cliente, CDU_Cambio, CDU_Processo, CDU_Retencao FROM TDU_TRT_CabecDocumentos";
                var lstDoc = PriEngine.Engine.Consulta(qDoc);
                if (lstDoc.Vazia() || lstDoc.NoFim()) return;
                var integraPrimavera = new IntegraPrimavera();
                integraPrimavera.IntegraDocVendasErpPrimavera(documentoConv, lstDoc.Valor(0).ToString(),
                    DateTime.Now.Date, Convert.ToDouble(lstDoc.Valor(1)),
                    Convert.ToString(anoConv), lstDoc.Valor(2), lstDoc.Valor(3), numeroConv);
            }
            catch (Exception ex)
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
            string nomeMapa;
            if (documento == "COT")
            {
                nomeMapa = "TRT_SIM";
            }
            else if (documento == "REQ" || documento == "RQA")
            {
                nomeMapa = "TRT_REQ";
            }
            else if (documento == "RI")
            {
                nomeMapa = "TRT_RI";
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
            PriEngine.Platform.Mapas.SetFileProp(StdBSTipos.CRPEExportFormat.efPdf,
                @$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
            PriEngine.Platform.Mapas.JanelaPrincipal = 0;
            PriEngine.Platform.Mapas.SelectionFormula =
                $"{{TDU_TRT_CabecDocumentos.CDU_Documento}} = '{documento}' AND " +
                $"{{TDU_TRT_CabecDocumentos.CDU_Ano}} = {ano} AND " +
                $"{{TDU_TRT_CabecDocumentos.CDU_Numero}} = {numero} ";
            PriEngine.Platform.Mapas.ImprimeListagem(nomeMapa, docName);
            System.Diagnostics.Process.Start(@$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
        }

        #endregion
    }
}
