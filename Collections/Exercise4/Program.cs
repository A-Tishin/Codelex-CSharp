using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numHash = new HashSet<int>();
            Console.WriteLine("Enter num to check: ");
            int number = Convert.ToInt32(Console.ReadLine());
            numHash.Add(number);
            do
            {
                number = SumOfSquares(number);
                Console.WriteLine(number);
                if (number == 1)
                {
                    Console.WriteLine("Happy");
                    return;
                }

                if (numHash.Contains(number))
                {
                    Console.WriteLine("Not happy");
                    return;
                }

                numHash.Add(number);
            } while (number > 1 || numHash.Contains(number) != true);

            Console.ReadKey();
        }

        static int SumOfSquares(int input)
        {
            int square = 0;
            char[] arr = Convert.ToString(input).ToCharArray();
            foreach(var digit in arr)
            {
                int toSquare = Convert.ToInt32(digit.ToString());
                square += toSquare * toSquare;
            }

            return square;
        }

    }
}
