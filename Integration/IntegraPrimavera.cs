using StdBE100;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TesBE100;
using TRTv10.Engine;
using VndBE100;

namespace TRTv10.Integration
{
    class IntegraPrimavera
    {
        #region variaveis

        public static int NumDoc { get; set; }

        #endregion

        #region metodos publicos

        /// <summary>
        /// Recebe uma TextBox e altera o texto da mesma, ou seja, caso a textbox tenha uma virgula
        /// ele altera para um ponto Ex. 1000,10 -> 1000.10 para cumprir com a formataçao do SQL.
        /// </summary>
        /// <param name="sender"></param>
       public void ImprimeDocVendas(string tipoDoc, string serie, int numDoc)
        {
            string reportTemplate;
            
            if (tipoDoc == "REQ" || tipoDoc == "RQA")
            {
                reportTemplate = "TRT_REQ";
            } 
            else if (tipoDoc == "FA" || tipoDoc == "ND")
            {
                reportTemplate = "TRT_FA";
            }
            else if (tipoDoc == "FR")
            {
                reportTemplate = "TRT_FR";
            }
            else if (tipoDoc == "RI")
            {
                reportTemplate = "TRT_RI";
            }
            else if (tipoDoc == "NC")
            {
                reportTemplate = "TRT_NC";
            }
            else if (tipoDoc == "COT")
            {
                reportTemplate = "TRT_SIM";
            }
            else
            {
                reportTemplate = "GCPVLS01";
            }

            // reportTemplate = "TRT_FR";
            string fileName = string.Format("{0}_{1}_{2}.pdf", tipoDoc, numDoc, serie);
            PriEngine.Engine.Vendas.Documentos.ImprimeDocumento(tipoDoc, serie, numDoc, "000", 1, reportTemplate, true, @$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
            System.Diagnostics.Process.Start(@$"\\192.168.10.10\primavera\SG100\Mapas\App\{fileName}");
        }

        public void CriaProcesso(string processo, string simulacao, SqlConnection sqlCon, SqlTransaction transaction)
        {
            Processo(processo, simulacao, sqlCon, transaction);
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
            string likeTipoServ = "%" + tipoServ + "%";

            sql.Append($"INSERT INTO [dbo].[TDU_TRT_ItemsServicos] ");
            sql.Append("([CDU_Id] ");
            sql.Append(",[CDU_Items] ");
            sql.Append(",[CDU_TipoServ] ");
            sql.Append(",[CDU_Operacao] ");
            sql.Append(",[CDU_Processo]) ");
            sql.Append($" SELECT NewId(), CDU_Nome, '{tipoServ}', '{operacao}', '{processo}' ");
            sql.Append($"FROM TDU_TRT_Items WHERE CDU_TipoServ LIKE '{likeTipoServ}'");
            sql.Append("Order By CDU_Posicao");

            var query = sql.ToString();

            PriEngine.Engine.DSO.ExecuteSQL(query);
        }

        #endregion

        #region Integra com o ERP Primavera
        
        #region Documentos

        public void IntegraDocVendasErpPrimavera(string documento, string cliente, DateTime data, double cambio, string serie,
            string processo, bool retencao, long numDoc)
        {
            CriaDocVenda(documento, cliente, data, cambio, serie, processo, retencao, numDoc);
        }

        private void CriaDocVenda(string documento, string cliente, DateTime data, double cambio, string serie,
            string processo, bool retencao, long numDoc)
        {
            var docVenda = new VndBEDocumentoVenda();
            var avisos = string.Empty;
            var sql = new StringBuilder();
            var i = 1;
            var queryCli = $"SELECT Cliente FROM Clientes WHERE Nome = '{cliente}'";
            StdBELista lstCliente;
            lstCliente = PriEngine.Engine.Consulta(queryCli);
            string codCliente;

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
                docVenda.SujeitoRetencao = retencao;
                
                //LinhasDocumentos
                sql.Append("SELECT I.CDU_CodPrimavera, D.CDU_Processo, L.CDU_PrecUnit, L.CDU_PrecIVA ");
                sql.Append("FROM TDU_TRT_LinhasDocumentos L ");
                sql.Append("INNER JOIN TDU_TRT_CabecDocumentos D ");
                sql.Append("ON D.CDU_Id = L.CDU_IdDoc ");
                sql.Append("INNER JOIN TDU_TRT_Items I ");
                sql.Append("ON L.CDU_Item = I.CDU_Nome ");
                sql.Append($"WHERE D.CDU_Documento = '{documento}' ");
                sql.Append($"AND D.CDU_Ano = '{serie}' ");
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

        #endregion
        
        #endregion
    }
}
