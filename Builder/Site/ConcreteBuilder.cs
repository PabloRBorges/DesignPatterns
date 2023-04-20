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

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Products GetProduct()
        {
            Products result = _product;

            Reset();

            return result;
        }
    }
}
