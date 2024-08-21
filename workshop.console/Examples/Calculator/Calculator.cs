using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Calculator
{
    public class Calculator
    {
        ICalculation _calculation;
        public Calculator(ICalculation calculation)
        {
            _calculation = calculation;
        }
        public int Calculate(int a, int b)
        {
            return _calculation.Calculate(a,b);
        }
    }
}
