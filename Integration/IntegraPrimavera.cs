using StdBE100;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using TesBE100;
using TRTv10.Engine;
using VndBE100;

namespace TRTv10.Integration
{
    class IntegraPrimavera
    {
        #region variaveis

        public int NumDoc { get; set; }

        private Guid IdDoc { get; set; }

        #endregion

        #region metodos publicos

        public string ItemDocumento(string item)
        {
            string erpDoc = string.Empty;
            string query = $"SELECT CDU_DocPrimavera FROM TDU_TRT_Items WHERE CDU_Nome = {item}";

            StdBELista lstDoc = PriEngine.Engine.Consulta(query);

            if (!lstDoc.Vazia())
            {
                erpDoc = lstDoc.Valor(0);
            }

            MessageBox.Show(item);
            return erpDoc;

        }

        public string ExisteReq(string simulacao, string documento)
        {
            string strDoc;
            var lstReq = new StdBELista();

            var queryProc = "SELECT CDU_Codigo " + " FROM TDU_TRT_Processo WHERE CDU_NumSimulacao = " +
                            "'" + simulacao + "'";
            var lstProc = PriEngine.Engine.Consulta(queryProc);

            if (!lstProc.Vazia())
            {
                string numProc = lstProc.Valor(0).ToString();

                var queryReq = "SELECT CDU_Documento, CDU_Serie, CDU_Numero " +
                               " FROM TDU_TRT_CabecDocumentos WHERE CDU_Documento = '" + documento +
                               "' AND CDU_Processo = '" + numProc + "'";
                lstReq = PriEngine.Engine.Consulta(queryReq);
            }

            if (!lstReq.Vazia())
                strDoc = lstReq.Valor(0).ToString() + " " + lstReq.Valor(2).ToString() + "/" +
                         lstReq.Valor(1).ToString();
            else
                strDoc = "vazio";

            return strDoc;
        }

        public void CriaDocumentoErp(string documento, string cliente, DateTime data, double cambio, string serie,
            string processo)
        {
            DocVendasErp(documento, cliente, data, cambio, serie, processo);
        }
        
        public void CriaDocumentoErpTrt(string documento, string cliente, DateTime data, double cambio, string serie,
            string processo, List<Linha> linhas)
        {
            DocVendasErpTrt(documento, cliente, data, cambio, serie, processo, linhas);
        }

        public void CriaProcesso(string processo, string simulacao, SqlConnection sqlCon, SqlTransaction transaction)
        {
            Processo(processo, simulacao, sqlCon, transaction);
        }

        public void CriaDocumento(string documento, string serie, DateTime data, string processo, string simulacao,
            SqlConnection sqlCon, SqlTransaction transaction, Guid idOrig, Guid idLin, string artigo, double precUnit)
        {
            CabecDoc(documento, serie, data, processo, sqlCon, transaction);

            if (documento == "REQ")
                LinhasDocReq(simulacao, sqlCon, transaction);
            else if(documento == "RQA")
                LinhasDocRqa(artigo, precUnit, sqlCon, transaction);
            else
                LinhasDoc(idLin, idOrig, sqlCon, transaction);
        }

        public void CriaItemsServico(string processo, string tipoServ, string operacao)
        {
            ItemsServicos(processo, tipoServ, operacao);
        }

        public string GeraProcesso(string tipoProcesso)
        {
            var sql = new StringBuilder();
            var tipoProc = string.Empty;
            var ano = DateTime.Now.Year.ToString();
            var data = ano.Substring(ano.Length - 2);

            if (tipoProcesso == "Marítimo")
                tipoProc = "1";
            else if (tipoProcesso == "Aéreo")
                tipoProc = "2";
            else if (tipoProcesso == "Terrestre") tipoProc = "3";

            var processo = $"{data}{tipoProc}%";

            sql.Append("SELECT MAX(RIGHT(CDU_Codigo, 4)) ");
            sql.Append("FROM [dbo].[TDU_TRT_Processo] ");
            sql.Append($"WHERE CDU_Codigo LIKE '{processo}' ");

            var query = sql.ToString();

            var lstPesquisa = PriEngine.Engine.Consulta(query);

            if (lstPesquisa.Vazia() || lstPesquisa.Valor(0).ToString() == "")
            {
                processo = $"{data}{tipoProc}0001";
            }
            else
            {
                int maxCodigo = Convert.ToInt32(lstPesquisa.Valor(0)) + 1;
                processo = string.Empty;

                if (maxCodigo.ToString().Length == 1)
                    processo = $"{data}{tipoProc}000{maxCodigo}";
                else if (maxCodigo.ToString().Length == 2)
                    processo = $"{data}{tipoProc}00{maxCodigo}";
                else if (maxCodigo.ToString().Length == 3) processo = $"{data}{tipoProc}0{maxCodigo}";
            }

            return processo;
        }

        public string NomeCliente(string codCliente)
        {
            var nomeCliente = string.Empty;

            if (codCliente != "") nomeCliente = PriEngine.Engine.Base.Clientes.DaNome(codCliente);

            return nomeCliente;
        }

        public void ConvertLinhas(Guid idLin, SqlConnection sqlCon, SqlTransaction transaction)
        {
            LinhasConvertidas(idLin, sqlCon, transaction);
        }

        public void CriaAprovacao(string documento, string serie, string processo, 
            SqlConnection sqlCon, SqlTransaction transaction)
        {
            CriaAprovacoes(documento, serie, processo, sqlCon, transaction);
        }

        #endregion

        #region metodos privados

        /// <summary>
        ///     Integraçao dos documentos do Explorer para o ERP, neste caso cria
        ///     o documento de tesouraria.
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="conta"></param>
        /// <param name="data"></param>
        /// <param name="cambio"></param>
        /// <param name="serie"></param>
        /// <param name="movim"></param>
        /// <param name="descricao"></param>
        /// <param name="valor"></param>
        /// <param name="moeda"></param>
        private void DocTesourariaErp(string documento, string conta, DateTime data,
            double cambio, string serie, string movim, string descricao, double valor, string moeda)
        {
            var docTes = new TesBEDocumentoTesouraria();

            try
            {
                docTes.Filial = "000";
                docTes.Tipodoc = documento;
                docTes.Serie = serie;
                docTes.ContaOrigem = conta;
                docTes.Data = data;
                docTes.TipoEntidade = "C";
                docTes.Utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
                docTes.ModuloOrigem = "B";
                docTes.DataIntroducao = data;
                docTes.Cambio = 1;
                docTes.CambioMAlt = cambio;
                docTes.CambioMBase = 1;
                docTes.TipoLancamento = "000";
                docTes.Moeda = moeda;

                PriEngine.Engine.Tesouraria.Documentos.AdicionaLinha(docTes, movim, conta, moeda, valor, "C", "", "",
                    descricao);

                PriEngine.Engine.Tesouraria.Documentos.Actualiza(docTes);
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso("Erro ao criar o documento " + documento +
                                                        " no erp primavera: " + ex.Message);
            }
        }

        private void DocVendasErp(string documento, string cliente, DateTime data, double cambio, string serie,
            string processo)
        {
            var docVenda = new VndBEDocumentoVenda();
            var avisos = string.Empty;
            var sql = new StringBuilder();
            var i = 1;
            var queryCli = $"SELECT Cliente FROM Clientes WHERE Nome = '{cliente}'";
            StdBELista lstCliente;
            lstCliente = PriEngine.Engine.Consulta(queryCli);
            string codCliente;
            long numDoc = NumDoc;

            if (!lstCliente.Vazia())
            {
                codCliente = lstCliente.Valor(0);
            }
            else
            {
                codCliente = cliente;
            }
                
            try
            {
                docVenda.Tipodoc = documento;
                docVenda.Serie = serie;
                docVenda.TipoEntidade = "C";
                docVenda.Entidade = codCliente;

                PriEngine.Engine.Vendas.Documentos.PreencheDadosRelacionados(docVenda);

                docVenda.DataDoc = data;
                docVenda.DataGravacao = data;
                docVenda.DataVenc = data;
                docVenda.Cambio = cambio;
                docVenda.CambioMBase = cambio;
                docVenda.Referencia = processo;
                docVenda.Requisicao = processo;

                sql.Append("SELECT L.CDU_Artigo, D.CDU_Processo, L.CDU_PrecUnit, L.CDU_IVA ");
                sql.Append("FROM TDU_TRT_LinhasDocumentos L ");
                sql.Append("INNER JOIN TDU_TRT_CabecDocumentos D ");
                sql.Append("ON D.CDU_Id = L.CDU_IdDoc ");
                sql.Append($"WHERE D.CDU_Documento = '{documento}' ");
                sql.Append($"AND D.CDU_Serie = '{serie}' ");
                sql.Append($"AND D.CDU_Numero = '{numDoc}' ");    

                var strProcesso = sql.ToString();

                StdBELista lstProcesso = PriEngine.Engine.Consulta(strProcesso);

                if (!lstProcesso.Vazia())
                    while (!lstProcesso.NoFim())
                    {
                        var qtd = Convert.ToDouble(1);
                        string artigo = lstProcesso.Valor(0).ToString();
                        bool iva = Convert.ToBoolean(lstProcesso.Valor(3));

                        PriEngine.Engine.Vendas.Documentos.AdicionaLinha(docVenda, artigo, ref qtd);

                        var linhasVenda = docVenda.Linhas;
                        linhasVenda.GetEdita(i).PrecUnit = lstProcesso.Valor(2);

                        if (iva.ToString() == "True")
                            linhasVenda.GetEdita(i).CodIva = "14";
                        else
                            linhasVenda.GetEdita(i).CodIva = "90";

                        lstProcesso.Seguinte();
                        i += 1;
                    }

                PriEngine.Engine.Vendas.Documentos.CalculaValoresTotais(docVenda);

                PriEngine.Engine.Vendas.Documentos.Actualiza(docVenda, ref avisos);

                NumDoc = 0;
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar o documento {documento} " +
                                                        $"no erp primavera: {ex.Message}");
            }
        }

        private void DocVendasErpTrt(string documento, string cliente, DateTime data, double cambio, string serie,
            string processo,  List<Linha> linhas)
        {
            var docVenda = new VndBEDocumentoVenda();
            var avisos = string.Empty;
            bool iva;
            try
            {
                docVenda.Tipodoc = documento; 
                docVenda.Serie = serie;
                docVenda.TipoEntidade = "C";
                docVenda.Entidade = cliente;

                PriEngine.Engine.Vendas.Documentos.PreencheDadosRelacionados(docVenda);

                docVenda.DataDoc = data;
                docVenda.DataGravacao = data;
                docVenda.DataVenc = data;
                docVenda.Cambio = cambio;
                docVenda.CambioMBase = cambio;
                docVenda.Referencia = processo;
                docVenda.Requisicao = processo;

                for (int i = 0; i < linhas.Count; i++)
                {
                    var qtd = Convert.ToDouble(1);
                    string artigo = linhas[i]._artigo;
                    
                    if (linhas[i]._precIva > 0)
                    {
                        iva = true;
                    }
                    else
                    {
                        iva = false;
                    }

                    PriEngine.Engine.Vendas.Documentos.AdicionaLinha(docVenda, artigo, ref qtd);

                    var linhasVenda = docVenda.Linhas;
                    linhasVenda.GetEdita(i+1).PrecUnit = linhas[i]._precUnit;

                    if (iva.ToString() == "True")
                    {
                        linhasVenda.GetEdita(i+1).CodIva = "14";
                    }
                    else
                    {
                        linhasVenda.GetEdita(i+1).CodIva = "90";
                    }
                }

                PriEngine.Engine.Vendas.Documentos.CalculaValoresTotais(docVenda);
                PriEngine.Engine.Vendas.Documentos.Actualiza(docVenda, ref avisos);
                NumDoc = 0;
            }
            catch (Exception ex) 
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar o documento {documento} no erp primavera: {ex.Message}");
            }
        }

        private void CabecDoc(string documento, string serie, DateTime data, string processo, SqlConnection sqlCon,
            SqlTransaction transaction)
        {
            var utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
            var sqlNum = new StringBuilder();
            IdDoc = Guid.NewGuid();

            sqlNum.Append("SELECT CDU_Numerador ");
            sqlNum.Append("FROM TDU_TRT_Serie ");
            sqlNum.Append($"WHERE CDU_Documento = '{documento}' AND CDU_PreDefinido = 1 ");

            var queryNum = sqlNum.ToString();

            var lstNum = PriEngine.Engine.Consulta(queryNum);

            if (!lstNum.Vazia())
                NumDoc = Convert.ToInt32(lstNum.Valor(0)) + 1;
            else
                NumDoc = 1;

            var sqlCmd = new SqlCommand("TDU_TRT_InsertCabecDoc", sqlCon)
            {
                Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@id", IdDoc);
            sqlCmd.Parameters.AddWithValue("@documento", documento);
            sqlCmd.Parameters.AddWithValue("@serie", serie);
            sqlCmd.Parameters.AddWithValue("@numDoc", NumDoc);
            sqlCmd.Parameters.AddWithValue("@dataDoc", data.Date);
            sqlCmd.Parameters.AddWithValue("@dataCria", DateTime.Now.Date);
            sqlCmd.Parameters.AddWithValue("@processo", processo);
            sqlCmd.Parameters.AddWithValue("@utilizador", utilizador);
            sqlCmd.ExecuteNonQuery();

            var sqlUp = new SqlCommand(
                $"UPDATE TDU_TRT_Serie  SET CDU_Numerador = '{NumDoc}' WHERE CDU_Documento = '{documento}' AND CDU_PreDefinido = 1 ",
                sqlCon) {Connection = sqlCon, Transaction = transaction};
            sqlUp.ExecuteNonQuery();
        }

        private int UltimoNumDoc(string documento, string serie, SqlConnection sqlCon, SqlTransaction transaction)
        {
            int ultNum = 0;
            using (SqlCommand sqlCmd = new SqlCommand($"SELECT MAX(CDU_Numero) As 'NumDoc' FROM TDU_TRT_CabecDocumentos " +
                                        $" WHERE CDU_Documento = '{documento}' AND CDU_Serie = '{serie}' ", sqlCon, transaction))
            {
                //sqlCon.Open();
                using (SqlDataReader reader = sqlCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ultNum = reader.GetInt32(reader.GetOrdinal("NumDoc"));
                        }
                    }
                }
            }
            
            return ultNum;
        }

        private void CriaAprovacoes(string documento, string serie,string processo, SqlConnection sqlCon,
            SqlTransaction transaction)
        {
            var numDoc = UltimoNumDoc(documento, serie, sqlCon, transaction);
            Guid idDoc = Guid.Empty;
            string cliente = string.Empty;
            string nome = string.Empty;

            using (SqlCommand sqlCmd = new SqlCommand($"SELECT CDU_Id As 'Id', CDU_Cliente As 'Cliente', CDU_Nome As 'Nome' FROM TDU_TRT_CabecDocumentos " +
                                                      $"WHERE CDU_Documento = '{documento}' AND CDU_Serie = '{serie}' AND CDU_Numero = {numDoc} ", sqlCon, transaction))
            {
                //sqlCon.Open();
                using (SqlDataReader reader = sqlCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idDoc = reader.GetGuid(reader.GetOrdinal("Id"));
                            cliente = reader.GetString(reader.GetOrdinal("Cliente"));
                            nome = reader.GetString(reader.GetOrdinal("Nome"));
                        }
                    }
                }
            }

            var sqlCmdIn = new SqlCommand("TDU_TRT_InsertAprovacoes", sqlCon)
            {
                Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
            };
            sqlCmdIn.Parameters.AddWithValue("@idDoc", idDoc);
            sqlCmdIn.Parameters.AddWithValue("@documento", documento);
            sqlCmdIn.Parameters.AddWithValue("@serie", serie);
            sqlCmdIn.Parameters.AddWithValue("@numDoc", numDoc);
            sqlCmdIn.Parameters.AddWithValue("@dataDoc", DateTime.Now.Date);
            sqlCmdIn.Parameters.AddWithValue("@processo", processo);
            sqlCmdIn.Parameters.AddWithValue("@cliente", cliente);
            sqlCmdIn.Parameters.AddWithValue("@nome", nome);
            sqlCmdIn.ExecuteNonQuery();
        }

        private void LinhasDocReq(string simulacao, SqlConnection sqlCon, SqlTransaction transaction)
        {
            var sql = new StringBuilder();
            var i = 1;

            sql.Append("SELECT I.CDU_CodPrimavera, I.CDU_IVA, S.CDU_ValoresSimulacao, S.CDU_IvaSimulacao ");
            sql.Append("FROM TDU_TRT_ItemsServicos S ");
            sql.Append("INNER JOIN TDU_TRT_Items I ");
            sql.Append("ON S.CDU_Items = I.CDU_Nome ");
            sql.Append($"WHERE S.CDU_Processo = '{simulacao}' ");
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
                sqlCmdLin.Parameters.AddWithValue("@id", IdDoc);
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

        private void LinhasDocRqa(string artigo, double precUnit, SqlConnection sqlCon, SqlTransaction transaction)
        {
            try
            {
                var sql = new StringBuilder();
                var i = 1;

                sql.Append($"SELECT CDU_IVA, CDU_Codigo FROM TDU_TRT_Items WHERE CDU_Nome = '{artigo}'");
                var query = sql.ToString();
                var lstArtigo = PriEngine.Engine.Consulta(query);
                double precIva = 0;
                string iva = string.Empty;

                if (!lstArtigo.Vazia())
                {
                    artigo = lstArtigo.Valor(1).ToString();
                    
                    if (lstArtigo.Valor(0) != false)
                    {
                        iva = "1";
                        precIva = precUnit * 0.14;
                    }
                    else
                    {
                        iva = "0";
                    }
                }

                double total = precIva + precUnit;

                var sqlCmdLin = new SqlCommand("TDU_TRT_InsertLinhasDoc", sqlCon)
                {
                    Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
                };
                sqlCmdLin.Parameters.AddWithValue("@id", IdDoc);
                sqlCmdLin.Parameters.AddWithValue("@i", i);
                sqlCmdLin.Parameters.AddWithValue("@artigo", artigo);
                sqlCmdLin.Parameters.AddWithValue("@iva", iva);
                sqlCmdLin.Parameters.AddWithValue("@precUnit", precUnit);
                sqlCmdLin.Parameters.AddWithValue("@precIVA", precIva);
                sqlCmdLin.Parameters.AddWithValue("@total", total);
                sqlCmdLin.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraAviso($"Erro ao criar as linhas do documento {ex.Message}");
            }

        }
        
        private void LinhasDoc(Guid idLin, Guid idOrig, SqlConnection sqlCon, SqlTransaction transaction)
        {
            var sql = new StringBuilder();
            var i = 1;

            sql.Append("SELECT CDU_Artigo, CDU_IVA, CDU_PrecUnit, CDU_PrecIVA, CDU_Total ");
            sql.Append("FROM TDU_TRT_LinhasDocumentos ");
            sql.Append($"WHERE CDU_Id = '{idLin}' ");
            sql.Append($"AND CDU_IdDoc = '{idOrig}' ");
            sql.Append("AND CDU_Convertido = 0 ");

            var query = sql.ToString();

            var lstLinhas = PriEngine.Engine.Consulta(query);

            if (!lstLinhas.Vazia())
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
                    sqlCmdLin.Parameters.AddWithValue("@id", IdDoc);
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
            else
                PriEngine.Platform.Dialogos.MostraAviso("A linha já foi convertida anteriormente");
        }

        private void LinhasConvertidas(Guid idLin, SqlConnection sqlCon, SqlTransaction transaction)
        {
            var query = $"UPDATE TDU_TRT_LinhasDocumentos SET CDU_Convertido = 1 WHERE CDU_Id = @idLin";
            var sqlCmd = new SqlCommand(query, sqlCon)
            {
                Connection = sqlCon, Transaction = transaction, CommandType = CommandType.Text
            };
            sqlCmd.Parameters.AddWithValue("@idLin", idLin.ToString());
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Parameters.Clear();
        }

        private void Processo(string processo, string simulacao, SqlConnection sqlCon, SqlTransaction transaction)
        {
            var nomeProcesso = $"Processo {processo}";
            string storeProcedure;

            if (simulacao == "directo")
                storeProcedure = "TDU_TRT_InsertProcessoDirecto";
            else
                storeProcedure = "TDU_TRT_InsertProcesso";

            var sqlCmdPr = new SqlCommand(storeProcedure, sqlCon)
            {
                Connection = sqlCon, Transaction = transaction, CommandType = CommandType.StoredProcedure
            };
            sqlCmdPr.Parameters.AddWithValue("@processo", processo);
            sqlCmdPr.Parameters.AddWithValue("@nomeProcesso", nomeProcesso);
            sqlCmdPr.Parameters.AddWithValue("@simulacao", simulacao);
            sqlCmdPr.ExecuteNonQuery();
        }

        private void ItemsServicos(string processo, string tipoServ, string operacao)
        {
            var sql = new StringBuilder();

            sql.Append($"INSERT INTO [dbo].[TDU_TRT_ItemsServicos] ");
            sql.Append("([CDU_Id] ");
            sql.Append(",[CDU_Items] ");
            sql.Append(",[CDU_TipoServ] ");
            sql.Append(",[CDU_Operacao] ");
            sql.Append(",[CDU_Processo]) ");
            sql.Append($" SELECT NewId(), CDU_Nome, '{tipoServ}', '{operacao}', '{processo}' ");
            sql.Append($"FROM TDU_TRT_Items WHERE CDU_TipoServ LIKE '{tipoServ}'");
            sql.Append("Order By CDU_Posicao");

            var query = sql.ToString();

            //PriEngine.Engine.DSO.ExecuteSQL(query);
        }

        #endregion
    }
}
