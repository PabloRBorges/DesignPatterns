namespace FactoryMethod.CartaoCreditos.Interfaces
{
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get;  }
        public abstract int LimiteCartao { get; set; }
        public abstract int TaxaAnual { get; set; }
    }
}
