using System;

namespace DragRace
{
    class Tesla: Car
    {
        public Tesla(string carBrand) : base(carBrand)
        {
        }
        public override void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}