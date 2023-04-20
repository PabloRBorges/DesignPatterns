using CommandPattern.Exe2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Exe2
{
    public class ConcreteCommand : ICommand
    {
        public int Id { get;private set; }
        public string Name { get; private set; }

        public ConcreteCommand(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Execute()
        {
            Console.WriteLine("Teste 2 de comando id:" + Id + "\n Nome:" + Name);
        }
    }
}
