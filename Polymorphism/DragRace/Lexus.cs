using System;

namespace DragRace
{
    public class Lexus : Car
    {
        public Lexus(string carBrand) : base(carBrand)
        {
        }

        public override void UseNitrousOxideEngine() 
        {
            currentSpeed += 3;
        }
    }
}