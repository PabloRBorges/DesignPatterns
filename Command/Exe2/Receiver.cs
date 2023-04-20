using CommandPattern.Exe2.Interfaces;

namespace CommandPattern.Exe2
{
    public class Receiver : IReceiver<ConcreteCommand, IState>
    {
        public IState Action(ConcreteCommand command)
        {
            command.Execute();
            return new State(100, "Documento gerado com sucesso");
        }
    }
}
