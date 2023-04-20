using FactoryMethod.Site;
using FactoryMethod.Youtube;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //YouTube
            //Creator creator = new ConcreteCreator();
            //var pagamentoAluguel = creator.FactoryMethod();
            //pagamentoAluguel.Pagar(2000);

            new Client().Main();
        }
    }
}
