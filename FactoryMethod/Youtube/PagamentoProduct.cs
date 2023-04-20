using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Youtube
{
    public abstract class PagamentoProduct
    {
        protected string _descricao { get; set; }
        protected string _tipo { get; set; }

        public abstract void Pagar(double valor);

    }
}
