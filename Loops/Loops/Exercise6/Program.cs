using System;

namespace Exercise6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Max value: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else if (i % 15 == 0)
                    Console.Write("FizzBuzz ");
                else
                    Console.Write(i + " ");
                if (i % 20 == 0)
                    Console.WriteLine();
            }
        }
    }
}
