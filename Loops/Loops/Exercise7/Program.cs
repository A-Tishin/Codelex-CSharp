using System;

namespace Exercise7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            int score = 0;
            
            do
            {
                int temp = Random();
                score += temp;
                Console.WriteLine($"You rolled a {temp}");

                if (temp == 1)
                {
                    score = 0;
                    Console.WriteLine(GameOver(score));
                    return;
                }

                Console.Write("Roll again? ");
                string choice = Console.ReadLine();

                if (choice == "n" || choice == "no")
                {
                    Console.WriteLine(GameOver(score));
                    return;
                }

            } while (score != 0);

            Console.WriteLine(GameOver(score));
            Console.ReadLine();
        }

        static int Random()
        {
            Random rnd = new Random();
            int rnd1To6 = rnd.Next(1, 7);
            return rnd1To6;
        }

        static string GameOver(int score)
        {
            return $"You got {score} points";
        }
    }
}
