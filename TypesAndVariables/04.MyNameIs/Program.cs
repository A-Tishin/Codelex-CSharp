using System;

namespace _04.MyNameIs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"My name is {name} and I was born in {year}.");
        }
    }
}
