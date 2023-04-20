using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Youtube
{
    public class PagamentoInternacional : PagamentoProduct
    {
        public PagamentoInternacional()
        {
            this._descricao = "compra internacional";
            this._tipo = "cartão de crédito";
        }

        public override void Pagar(double valor)
        {
            Console.WriteLine($"A conta {this._descricao} foi paga via {this._tipo} no valor de {valor} dólares");
        }
    }
}
