using AbstractFactoryMethod.Youtube.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Youtube.Factory.Products
{
    public class MediaSocialFacebook : MediaSocial
    {
        public override void Like()
        {
            Console.WriteLine("Essa publicação foi curtida no facebook");
        }

        public override void Post(string title, string body)
        {
            Console.WriteLine(title);
            Console.WriteLine(body + "Facebook");
        }
    }
}
