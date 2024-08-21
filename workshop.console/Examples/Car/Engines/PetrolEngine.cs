using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Car.Engines
{
    public class PetrolEngine : IEngine
    {
        public int EngineSize { get; } = 2000;

        public void Accelerate()
        {
            //code uniqu to petrol engine accelerate?
        }

        public void Start()
        {
            //processes to start petrol engine?
        }
    }
}
