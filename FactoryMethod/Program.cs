using FactoryMethod.CartaoCreditos2.Creator;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Cartão de crédito

            var cartao = new ConcreteBlack();
            cartao.ProcessaSolicitacaoCriacaoCartao();

            var cartao2 = new ConcretePlatinum();
            cartao2.ProcessaSolicitacaoCriacaoCartao();

            var cartao3 = new ConcreteGold();
            cartao3.ProcessaSolicitacaoCriacaoCartao();

            //YouTube
            //Creator creator = new ConcreteCreator();
            //var pagamentoAluguel = creator.FactoryMethod();
            //pagamentoAluguel.Pagar(2000);

            //new Client().Main();


        }
    }
}
