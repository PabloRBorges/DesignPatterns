//https://refactoring.guru/pt-br/design-patterns/adapter

using System;
/*
    Adaptadores podem não só converter dados em vários formatos, mas também podem ajudar objetos com diferentes interfaces a colaborar. Veja aqui como funciona:
    1 - O adaptador obtém uma interface, compatível com um dos objetos existentes.
    2 - Usando essa interface, o objeto existente pode chamar os métodos do adaptador com segurança.
    3 - Ao receber a chamada, o adaptador passa o pedido para o segundo objeto, mas em um formato e ordem que o segundo objeto espera.

    Como Implementar
    1 - Certifique-se que você tem ao menos duas classes com interfaces incompatíveis:
    2 - Uma classe serviço útil, que você não pode modificar (quase sempre de terceiros, antiga, ou com muitas dependências existentes).
    3 - Uma ou mais classes cliente que seriam beneficiadas com o uso da classe serviço.
    4 - Declare a interface cliente e descreva como o cliente se comunica com o serviço.
    5 - Cria a classe adaptadora e faça-a seguir a interface cliente. Deixe todos os métodos vazios por enquanto.
    6 - Adicione um campo para a classe do adaptador armazenar uma referência ao objeto do serviço. A prática comum é inicializar esse campo via o construtor, mas algumas vezes é mais conveniente passá-lo para o adaptador ao chamar seus métodos.
    7 - Um por um, implemente todos os métodos da interface cliente na classe adaptadora. O adaptador deve delegar a maioria do trabalho real para o objeto serviço, lidando apenas com a conversão da interface ou formato dos dados.
    8 - Os Clientes devem usar o adaptador através da interface cliente. Isso irá permitir que você mude ou estenda o adaptador sem afetar o código cliente.

 */

namespace RefactoringGuru.DesignPatterns.Adapter.Conceptual
{
    // The Target defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }

    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
