using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Calculator
{
    class Calculator
    {
        private int _currentValue;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _currentValue += operand;
                    break;
                case '-': _currentValue -= operand;
                    break;
                case '*': _currentValue *= operand;
                    break;
                case '/': _currentValue /= operand;
                    break;
            }

            Console.WriteLine("Current value = {0,3} (following {1} {2})", _currentValue, @operator, operand);
        }
    }
}
