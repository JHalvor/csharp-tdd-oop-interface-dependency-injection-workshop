using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Calculator
{
    public class AddCalcEngine : ICalculation
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
