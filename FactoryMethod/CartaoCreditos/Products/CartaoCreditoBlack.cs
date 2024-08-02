namespace FactoryMethod.CartaoCreditos.Interfaces
{
    public class CartaoCreditoBlack : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCartao;
        private int _taxaAnual;

        public CartaoCreditoBlack(int limiteCartao, int taxaAnual)
        {
            _tipoCartao = "Black";
            _limiteCartao = limiteCartao;
            _taxaAnual = taxaAnual;
        }

        public override string TipoCartao { get { return _tipoCartao; } }
        public override int LimiteCartao { get { return _limiteCartao; } set { _limiteCartao = value; } }
        public override int TaxaAnual { get { return _taxaAnual; } set { _taxaAnual = value; } }
    }
}
