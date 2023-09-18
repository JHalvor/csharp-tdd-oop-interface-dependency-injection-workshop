using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Car
{
    public class Beetle
    {
        private IEngine _engine;

        public Beetle(IEngine engine)
        {
            _engine = engine;
        }
        public void Start()
        {
            _engine.Start();

        }
        public void Drive()
        {
            _engine.Accelerate();
        }
    }
}
