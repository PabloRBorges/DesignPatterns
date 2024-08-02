using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CartaoCreditos2.Interfaces
{
    public interface ICartaoBase
    {
        public string Nome { get; }
        public int TaxaAnual { get; }
        public int LimiteCartao { get; }
    }
}
