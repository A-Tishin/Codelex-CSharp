using System;

namespace DateTestExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Date myBirthDay = new Date(day, month, year);
            myBirthDay.PrintDate();
        }
    }
}
