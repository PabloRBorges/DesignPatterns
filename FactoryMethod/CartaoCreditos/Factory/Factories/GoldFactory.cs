using FactoryMethod.CartaoCreditos.Interfaces;

namespace FactoryMethod.CartaoCreditos.Factory.Factories
{
    public class GoldFactory : CartaoCreditoFactory
    {
        private int _taxaAnual;
        private int _limiteCredito;

        public GoldFactory()
        {
            _taxaAnual = 100;
            _limiteCredito = 1000;
        }

        public override CartaoCredito PreparaCriacaoCartao()
        {
            return new CartaoCreditoGold(_limiteCredito, _taxaAnual);
        }
    }
}
