using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.ConsoleOrSpeak
{
    public class Communicate : ICommunicator
    {
        private ICommunicator _communicator;
        public Communicate()
        {
            
        }
        public Communicate(ICommunicator communicator)
        {
            _communicator = communicator;
        }
        public void SendMessage(string message)
        {
            _communicator.SendMessage(message);
        }
    }
}
