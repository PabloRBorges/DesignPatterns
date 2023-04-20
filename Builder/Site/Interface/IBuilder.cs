using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Site.Interface
{
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
