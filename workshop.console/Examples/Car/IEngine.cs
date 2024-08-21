using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Car
{
    public interface IEngine
    {
        int EngineSize { get; }
        void Start();
        void Accelerate();
    }
}
