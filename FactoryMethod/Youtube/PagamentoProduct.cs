namespace FactoryMethod.Youtube
{
    public abstract class PagamentoProduct
    {
        protected string _descricao { get; set; }
        protected string _tipo { get; set; }

        public abstract void Pagar(double valor);

    }
}
