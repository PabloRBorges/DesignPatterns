using FactoryMethod.CartaoCreditos.Interfaces;

namespace FactoryMethod.CartaoCreditos.Factory.Factories
{
    public class BlackFactory : CartaoCreditoFactory
    {
        private int _taxaAnual;
        private int _limiteCredito;

        public BlackFactory()
        {
            _taxaAnual = 2000;
            _limiteCredito = 500000;
        }

        public override CartaoCredito PreparaCriacaoCartao()
        {
            return new CartaoCreditoBlack(_limiteCredito, _taxaAnual);
        }
    }
}
