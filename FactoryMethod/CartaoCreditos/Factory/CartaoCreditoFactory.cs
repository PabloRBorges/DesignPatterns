using FactoryMethod.CartaoCreditos.Interfaces;

namespace FactoryMethod.CartaoCreditos.Factory
{
    public abstract class CartaoCreditoFactory
    {
        public abstract CartaoCredito PreparaCriacaoCartao();
    }
}
