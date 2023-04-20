using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Youtube
{
    public abstract class Creator
    {
        public abstract PagamentoProduct FactoryMethod();
    }
}
