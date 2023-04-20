using System;
/*
 *  Como implementar
Verifique se é possível providenciar uma interface mais simples que a que o subsistema já fornece. Você está no caminho certo se essa interface faz o código cliente independente de muitas classes do subsistema.

Declare e implemente essa interface em uma nova classe fachada. A fachada deve redirecionar as chamadas do código cliente para os objetos apropriados do subsistema. A fachada deve ser responsável por inicializar o subsistema e gerenciar seu ciclo de vida a menos que o código cliente já faça isso.

Para obter o benefício pleno do padrão, faça todo o código cliente se comunicar com o subsistema apenas através da fachada. Agora o código cliente fica protegido de qualquer mudança no código do subsistema. Por exemplo, quando um subsistema recebe um upgrade para uma nova versão, você só precisa modificar o código na fachada.

Se a fachada ficar grande demais, considere extrair parte de seu comportamento para uma nova e refinada classe fachada.
 */

namespace RefactoringGuru.DesignPatterns.Facade.Conceptual
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationZ();
            return result;
        }
    }

    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class Subsystem1
    {
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }

    // Some facades can work with multiple subsystems at the same time.
    public class Subsystem2
    {
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }


    class Client
    {
        // The client code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
