using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/*
 * Adaptadores podem não só converter dados em vários formatos, mas também podem ajudar objetos com diferentes interfaces a colaborar. Veja aqui como funciona:
  1 - O adaptador obtém uma interface, compatível com um dos objetos existentes.
  2 - Usando essa interface, o objeto existente pode chamar os métodos do adaptador com segurança.
  3 - Ao receber a chamada, o adaptador passa o pedido para o segundo objeto, mas em um formato e ordem que o segundo objeto espera.
 */
