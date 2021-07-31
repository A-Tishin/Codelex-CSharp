using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Honda: Car
    {
        public Honda(string carBrand) : base(carBrand) { }

        public override void UseNitrousOxideEngine()
        {
            currentSpeed += 2;
        }
    }
}
