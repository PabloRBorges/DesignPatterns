using FactoryMethod.CartaoCreditos2.Interfaces;

namespace FactoryMethod.CartaoCreditos2.Creator.Produto
{
    public class CreditGold : ICartaoBase
    {
        private readonly string _nome;
        private readonly int _taxaAnual;
        private readonly int _limiteCartao;

        public CreditGold()
        {
            _nome = "Gold";
            _taxaAnual = 500;
            _limiteCartao = 11000;
        }

        public string Nome { get { return _nome; } }
        public int TaxaAnual { get { return _taxaAnual; } }
        public int LimiteCartao { get { return _limiteCartao; } }

    }
}
