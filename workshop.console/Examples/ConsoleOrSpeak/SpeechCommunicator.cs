using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.ConsoleOrSpeak
{
    public class SpeechCommunicator : ICommunicator
    {
        public void SendMessage(string message)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(message);
        }
    }
}
