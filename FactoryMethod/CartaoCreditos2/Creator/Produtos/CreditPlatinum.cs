using FactoryMethod.CartaoCreditos2.Interfaces;

namespace FactoryMethod.CartaoCreditos2.Creator.Produto
{
    public class CreditPlatinum : ICartaoBase
    {
        private readonly string _nome;
        private readonly int _taxaAnual;
        private readonly int _limiteCartao;

        public CreditPlatinum()
        {
            _nome = "Platinum";
            _taxaAnual = 1500;
            _limiteCartao = 23000;
        }

        public string Nome { get { return _nome; } }
        public int TaxaAnual { get { return _taxaAnual; } }
        public int LimiteCartao { get { return _limiteCartao; } }
    }
}
