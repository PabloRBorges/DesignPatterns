using AbstractFactoryMethod.Youtube.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Youtube.Abstract
{
    public abstract class AbstractFactorys
    {
        public abstract MediaSocial CreateMediaSocial();
    }
}
