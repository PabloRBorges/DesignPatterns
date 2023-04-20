using Builder.Youtube.Build;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Youtube
{
    class Director
    {
        public Director(MidiaSocialBuilder builder)
        {
            builder.BuildPost();
            builder.BuildLike();
        }
    }
}
