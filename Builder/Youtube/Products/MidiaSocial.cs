using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Youtube.Products
{
    class MidiaSocial
    {
        private readonly string _nomeRedeSocial;
        public string RedeNome { get; private set; }
        private readonly ConsoleColor _color;

        public MidiaSocial(string nomeRedeSocial, ConsoleColor color)
        {
            _nomeRedeSocial = nomeRedeSocial;
            RedeNome = nomeRedeSocial;
            _color = color;
        }

        public void Post(string title, string body)
        {
            Console.ForegroundColor = _color; 
            Console.WriteLine(_nomeRedeSocial);
            Console.WriteLine(title);
            Console.WriteLine(body);
        }

        public void Like(string publicacao)
        {
            Console.WriteLine($"A {publicacao} foi curtida no {_nomeRedeSocial}");
            Console.ResetColor();
        }
    }
}
