using System;

namespace FuelgaugeAndOdo
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge gauge = new FuelGauge();
            gauge.Fill();
            Odometer odo = new Odometer(gauge);

            do
            {
                odo.Drive();
                Console.WriteLine(odo.Getmileage());
                Console.WriteLine(gauge.GetLiters());
            } while (gauge.Liters > 0);

            Console.ReadKey();
        }
    }
}
