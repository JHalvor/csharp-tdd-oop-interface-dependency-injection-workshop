using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Calculator
{

    //starts with an I then a capital letter!
    //interface keyword
    //cannot instance an interface!
    //interface defines behaviour BUT doesn't implement
    //only public members
    //class inherits interface - we say implements!
    //contract 

    public interface ICalculation
    {
        int Calculate(int a, int b);
    }
}
