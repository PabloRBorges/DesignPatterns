using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Youtube.Abstract.Products
{
    public abstract class MediaSocial
    {
        public abstract void Post(string title, string body);
        public abstract void Like();
    }
}
