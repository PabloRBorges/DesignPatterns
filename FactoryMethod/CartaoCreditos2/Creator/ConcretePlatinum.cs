using FactoryMethod.CartaoCreditos2.Creator.Produto;
using FactoryMethod.CartaoCreditos2.Interfaces;

namespace FactoryMethod.CartaoCreditos2.Creator
{
    public class ConcretePlatinum : CreatorAbstract
    {
        public override ICartaoBase CreatorFactory()
        {
            return new CreditPlatinum();
        }
    }
}
