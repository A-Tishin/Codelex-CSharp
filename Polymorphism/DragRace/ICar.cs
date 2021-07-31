using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    interface ICar
    {
        public void SpeedUp() {}

        public void SlowDown() {}

        public int GetCurrentSpeed();

        public void StartEngine() {}
    }
}

