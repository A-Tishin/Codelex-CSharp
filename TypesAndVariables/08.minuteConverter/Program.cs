using System;

namespace _08.minuteConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a lot of minutes: ");
            long minutes = Convert.ToInt64(Console.ReadLine());
            int years = 0;
            long days = minutes / 60 / 24;
            while (days > 365)
            {
                years++;
                days -= 365;
            }
            

            Console.WriteLine($"It is {years} year/s and {days} day/s.");
            Console.ReadKey();
        }
    }
}