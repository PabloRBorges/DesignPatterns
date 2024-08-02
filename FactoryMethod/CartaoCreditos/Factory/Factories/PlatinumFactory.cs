using FactoryMethod.CartaoCreditos.Interfaces;

namespace FactoryMethod.CartaoCreditos.Factory.Factories
{
    public class PlatinumFactory : CartaoCreditoFactory
    {
        private int _taxaAnual;
        private int _limiteCredito;

        public PlatinumFactory()
        {
            _taxaAnual = 1200;
            _limiteCredito = 50000;
        }

        public override CartaoCredito PreparaCriacaoCartao()
        {
            return new CartaoCreditoPlatinum(_limiteCredito, _taxaAnual);
        }
    }
}
