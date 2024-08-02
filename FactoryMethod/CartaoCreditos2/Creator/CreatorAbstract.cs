using FactoryMethod.CartaoCreditos2.Interfaces;
using System;
using System.Collections.Generic;

namespace FactoryMethod.CartaoCreditos2.Creator
{
    public abstract class CreatorAbstract
    {
        public abstract ICartaoBase CreatorFactory();

        public void ProcessaSolicitacaoCriacaoCartao()
        {
            var cart = CreatorFactory();
            var mensagems = GerarMensagemCliente(cart);

            foreach (var mensagem in mensagems)
            {
                Console.WriteLine(mensagem);
            }
        }

        private List<string> GerarMensagemCliente(ICartaoBase cartao)
        {
            var list = new List<string>
            {
                $"Cartão {cartao.Nome} gerado com sucesso!",
                $"Limite:{cartao.LimiteCartao}",
                $"Taxa Anual:{cartao.TaxaAnual}"
            };

            Console.WriteLine("[SISTEMA] Cartao finalizado");

            return list;
        }
    }
}
