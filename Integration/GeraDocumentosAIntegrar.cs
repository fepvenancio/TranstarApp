namespace TRTv10.Integration
{
    public class Linha
    {
        public string _artigo;
        public double _qtd;
        public double _precUnit;
        public double _precIva;
        public bool _retencao;

        public Linha(string artigo, double qtd, double precUnit, double precIva, bool retencao)
        {
            _artigo = artigo;
            _qtd = qtd;
            _precUnit = precUnit;
            _precIva = precIva;
            _retencao = retencao;
        }
    }
}
