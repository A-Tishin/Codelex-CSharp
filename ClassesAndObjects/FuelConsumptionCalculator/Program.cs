using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car lexus = new Car(0);

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($"You are at the gas station. Enter your mileage: ");
                int mileage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"And how much liters to fill: ");
                int liters = Convert.ToInt32(Console.ReadLine());

                lexus.FillUp(mileage, liters);
                Console.Clear();
                Console.WriteLine($"Your car consumes {lexus.CalculateConsumption()} liters per 100km.");
                Console.WriteLine($"Is it GasHog? {lexus.GasHog()}");

                if (lexus.GasHog() == false)
                {
                    Console.WriteLine($"Or maybe EconoCar? {lexus.EconomyCar()}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
