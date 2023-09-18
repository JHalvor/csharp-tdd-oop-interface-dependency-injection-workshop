using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Calculator.Interfaces
{
    public class MultiplyCalc : ICalculation
    {
        public int Calculate(int a, int b)
        {
           return a * b;
        }
    }
}
