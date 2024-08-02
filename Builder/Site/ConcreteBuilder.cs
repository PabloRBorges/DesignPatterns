using Builder.Site.Interface;
using Builder.Site.Product;

namespace Builder.Site
{
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class ConcreteBuilder : IBuilder
    {
        private Products _product = new Products();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Products();
        }

        // All production steps work with the same product instance.
        public void BuildPartA()
        {
            _product.Add("PartA1");
        }

        public void BuildPartB()
        {
            _product.Add("PartB1");
        }

        public void BuildPartC()
        {
            _product.Add("PartC1");
        }

        public Products GetProduct()
        {
            Products result = _product;

            Reset();

            return result;
        }
    }
}
