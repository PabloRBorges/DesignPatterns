using CommandPattern.Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Calculator
{

    class Invoker
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            _commands.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            if (_commands.Count > 0)
            {
                ICommand command = _commands.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }
}
