using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace DragRace
{
    public class Car: ICar, IBoost
    {
        public int currentSpeed = 0;
        public string CarBrand { get; set; }
        public Car(string carBrand)
        {
            CarBrand = carBrand;
        }

        public void SpeedUp()
        {
            currentSpeed++;
        }

        public void SlowDown()
        {
            currentSpeed--;
        }

        public int GetCurrentSpeed()
        {
            return currentSpeed;
        }

        public virtual void UseNitrousOxideEngine(){}

        public virtual void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
