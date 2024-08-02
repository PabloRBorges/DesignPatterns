using System;

namespace FactoryMethod.Youtube
{
    public class PagamentoAluguel : PagamentoProduct
    {
        public PagamentoAluguel()
        {
            this._descricao = "Aluguel";
            this._tipo = "boleto";
        }

        public override void Pagar(double valor)
        {
            Console.WriteLine($"A conta {this._descricao} foi paga via {this._tipo} no valor de {valor}");
        }
    }
}
