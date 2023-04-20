/*
Como implementar
1 - Identifique as dimensões ortogonais em suas classes. Esses conceitos independentes podem ser: abstração/plataforma, domínio/infraestrutura, front-end/back-end, ou interface/implementação.
2 - Veja quais operações o cliente precisa e defina-as na classe abstração base.
3 - Determine as operações disponíveis em todas as plataformas. Declare aquelas que a abstração precisa na interface geral de implementação.
4 - Crie classes concretas de implementação para todas as plataformas de seu domínio, mas certifique-se que todas elas sigam a interface de implementação.
5 - Dentro da classe de abstração, adicione um campo de referência para o tipo de implementação. A abstração delega a maior parte do trabalho para o objeto de implementação que foi referenciado neste campo.
6 - Se você tem diversas variantes de lógica de alto nível, crie abstrações refinadas para cada variante estendendo a classe de abstração básica.
7 - O código cliente deve passar um objeto de implementação para o construtor da abstração para associar um com ou outro. Após isso, o cliente pode esquecer sobre a implementação e trabalhar apenas com o objeto de abstração. 
 */

using System;

namespace DesignPatterns.Bridge.Conceptual
{

    // The Implementation defines the interface for all implementation classes.
    // It doesn't have to match the Abstraction's interface. In fact, the two
    // interfaces can be entirely different. Typically the Implementation
    // interface provides only primitive operations, while the Abstraction
    // defines higher- level operations based on those primitives.
    public interface IImplementation
    {
        string OperationImplementation();
    }

    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }

    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }

    // The Abstraction defines the interface for the "control" part of the two
    // class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }

    // You can extend the Abstraction without changing the Implementation
    // classes.
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }

    class Client
    {
        // Except for the initialization phase, where an Abstraction object gets
        // linked with a specific Implementation object, the client code should
        // only depend on the Abstraction class. This way the client code can
        // support any abstraction-implementation combination.
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}