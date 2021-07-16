using System;

namespace _4.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number from 0 to 6: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var day = "it's a ";

            switch (input)
            {
                case 1: 
                    day += "sunday.";
                    break;
                case 2: 
                    day += "monday.";
                    break;
                case 3:
                    day += "tuesday."; 
                    break;
                case 4:
                    day += "wednesday.";
                    break;
                case 5:
                    day += "thursday.";
                    break;
                case 6:
                    day += "saturday.";
                    break;
                default: 
                    day = "Not a valid day";
                    break;
            }
            Console.WriteLine($"{day}");
        }
    }
}
