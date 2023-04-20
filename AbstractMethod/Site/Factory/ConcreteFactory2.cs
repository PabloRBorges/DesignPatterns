using AbstractFactory.Site;
using Site.Interface;
using Site.Product;

namespace Site.Factory
{
    // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}