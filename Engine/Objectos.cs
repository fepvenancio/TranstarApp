using System;

namespace TRTv10.Engine
{
    public struct Documento
    {
        public Guid IdOrig;
        public string TipoDoc; 
        public int Ano;
        public int Numero;
        public DateTime Data;
        public string Moeda;
        public double Cambio;
        public string Observacoes;
        public string Processo;
        public string Cotacao;
        public string TipoServ;
        public double ValorDoc;
        public double ValorIva;
        public double ValorRet;
        public double ValorTot;
        public double ValorRec;
        public string Utilizador;
        public string Cliente;
        public string Nome;
        public string Nif;
        public string Morada;
        public string Localidade;
        public string CodPostal;
        public string CodPostalLocalidade;
        public string Pais;
        public bool IvaCativo;
        public bool Retencao;
        public string DocEstorno;
        public int NumEstorno;
        public int AnoEstorno;
        public string DocOriginal;
        public int AnoOriginal;
        public int NumOriginal;
        //DataGridView dataGridView

        public Documento( Guid idOrig, string documento, int ano, int numero, DateTime data, string moeda,
         double cambio, string observacoes, string processo, string cotacao, string tipoServ,
         double valorDoc, double valorIva, double valorRet, double valorTot, double valorRec,
         string utilizador, string cliente, string nome, string nif, string morada, string localidade,
         string codPostal, string codPostalLocalidade, string pais, bool ivaCativo, bool retencao,
         string docEstorno, int numEstorno, int anoEstorno,
         string docOriginal, int anoOriginal, int numOriginal)
        {
            IdOrig = idOrig;
            TipoDoc = documento;
            Ano = ano;
            Numero = numero;
            Data = data;
            Moeda = moeda;
            Cambio = cambio;
            Observacoes = observacoes;
            Processo = processo;
            Cotacao = cotacao;
            TipoServ = tipoServ;
            ValorDoc = valorDoc;
            ValorIva = valorIva;
            ValorRet = valorRet;
            ValorTot = valorTot;
            ValorRec = valorRec;
            Utilizador = utilizador;
            Cliente = cliente;
            Nome = nome;
            Nif = nif;
            Morada = morada;
            Localidade = localidade;
            CodPostal = codPostal;
            CodPostalLocalidade = codPostalLocalidade;
            Pais = pais;
            IvaCativo = ivaCativo;
            Retencao = retencao;
            DocEstorno = docEstorno;
            NumEstorno = numEstorno;
            AnoEstorno = anoEstorno;
            DocOriginal = docOriginal;
            AnoOriginal = anoOriginal;
            NumOriginal = numOriginal;
        }
    }


    class Objectos
    {
    }
}
