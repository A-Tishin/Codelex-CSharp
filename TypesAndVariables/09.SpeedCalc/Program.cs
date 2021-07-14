using System;

namespace _09.SpeedCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance in meters: ");
            float distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter hours you spent: ");
            float hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutes: ");
            float minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Seconds: ");
            float seconds = Convert.ToInt32(Console.ReadLine());

            float metersPerSec = distance / (hours * 60 * 60 + minutes * 60 + seconds);
            float kmPerHour = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            float milesPerHour = (distance / 1609) / (hours + minutes / 60 + seconds / 3600);

            Console.WriteLine($"Your speed in meters/second is {metersPerSec}");
            Console.WriteLine($"Your speed in km/h is {kmPerHour}");
            Console.WriteLine($"Your speed in miles/h is {milesPerHour}");

            Console.ReadKey();
        }
    }
}