using FactoryMethod.CartaoCreditos2.Creator.Produto;
using FactoryMethod.CartaoCreditos2.Interfaces;

namespace FactoryMethod.CartaoCreditos2.Creator
{
    public class ConcreteGold : CreatorAbstract
    {
        public override ICartaoBase CreatorFactory()
        {
            return new CreditGold();
        }
    }
}
