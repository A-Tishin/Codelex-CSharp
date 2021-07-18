using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            var input = Console.ReadLine();

            if (input.Length > 9)
                Console.WriteLine("Number is too long.");
            else
                Console.WriteLine($"This number has {input.Length} digits.");

            Console.ReadKey();
        }
    }
}
