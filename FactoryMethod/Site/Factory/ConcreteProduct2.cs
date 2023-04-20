using FactoryMethod.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Site
{
    class ConcreteProduct2 : IProduct
    {
        public string OperationOfProduct()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
