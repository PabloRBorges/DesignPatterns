namespace FactoryMethod.Site
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperationOfCreator()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " + product.OperationOfProduct();

            return result;
        }
    }
}
