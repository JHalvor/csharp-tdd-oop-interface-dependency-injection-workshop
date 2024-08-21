using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Car
{
    public class Beetle : IEngine
    {
        private IEngine _engine;
        public Beetle(IEngine engine)
        {
            _engine = engine;
        }
        public int EngineSize => _engine.EngineSize;

        public void Accelerate()
        {
            _engine.Accelerate();
        }

        public void Start()
        {
            _engine.Start();
        }
    }
}
