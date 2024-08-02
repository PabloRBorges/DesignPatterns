namespace FactoryMethod.Youtube
{
    public class ConcreteCreator : Creator
    {
        public override PagamentoProduct FactoryMethod()
        {
            return new PagamentoInternacional();
        }
    }
}
