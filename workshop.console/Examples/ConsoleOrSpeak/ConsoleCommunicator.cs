using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.ConsoleOrSpeak
{
    public class ConsoleCommunicator : ICommunicator
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
