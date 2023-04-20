using CommandPattern.Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Calculator
{
    class CalculatorCommand : ICommand
    {
        private Calculator _calculator;
        private char _operator;
        private int _operand;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void Undo()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }
}
