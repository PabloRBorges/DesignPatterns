using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
