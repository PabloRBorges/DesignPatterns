namespace FactoryMethod.CartaoCreditos.Interfaces
{
    public class CartaoCreditoPlatinum : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCartao;
        private int _taxaAnual;

        public CartaoCreditoPlatinum(int limiteCartao, int taxaAnual)
        {
            _tipoCartao = "Platinum";
            _limiteCartao = limiteCartao;
            _taxaAnual = taxaAnual;
        }

        public override string TipoCartao { get { return _tipoCartao; } }
        public override int LimiteCartao { get { return _limiteCartao; } set { _limiteCartao = value; } }
        public override int TaxaAnual { get { return _taxaAnual; } set { _taxaAnual = value; } }
    }
}
