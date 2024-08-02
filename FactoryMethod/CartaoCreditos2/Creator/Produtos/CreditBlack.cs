using FactoryMethod.CartaoCreditos2.Interfaces;

namespace FactoryMethod.CartaoCreditos2.Creator.Produto
{
    public class CreditBlack : ICartaoBase
    {
        private readonly string _nome;
        private readonly int _taxaAnual;
        private readonly int _limiteCartao;

        public CreditBlack()
        {
            _nome = "Black";
            _taxaAnual = 2000;
            _limiteCartao = 50000;
        }

        public string Nome { get { return _nome; } }
        public int TaxaAnual { get { return _taxaAnual; } }
        public int LimiteCartao { get { return _limiteCartao; } }

    }
}
