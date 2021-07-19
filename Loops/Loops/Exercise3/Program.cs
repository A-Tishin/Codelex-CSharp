using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So there is some numbers. Which number index You want to know?");
            int[] numArray = new int[20];

            for (var i = 0; i < numArray.Length; i++)
            {
                numArray[i] = RandomNum();
                Console.Write(numArray[i] + " ");
            }
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"It's {Array.IndexOf(numArray, choice)}.");
            Console.ReadKey();
        }

        static int RandomNum()
        {
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }
    }
}
