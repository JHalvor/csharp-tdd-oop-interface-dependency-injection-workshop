using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.ConsoleOrSpeak
{
    public class Communicate
    {
        
        public void SendMessage(string message, ICommunicator communicator)
        {
            communicator.SendMessage(message);
        }
    }
}
