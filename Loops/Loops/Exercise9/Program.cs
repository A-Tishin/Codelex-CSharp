using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have two dices. Enter desirable sum, from 2 to 12, and we will try to throw it.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Desired sum: {input}");
            int sum;

            if (input > 1 && input < 13)
            {
                do
                {
                    int int1 = Random();
                    int int2 = Random();
                    sum = int1 + int2;
                    Console.WriteLine($"{int1} and {int2} = {int1 + int2}");
                } while (input != sum);
            }

            else
                Console.WriteLine("It's too big or too small for two dices.");
            Console.ReadLine();
        }

        static int Random()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
