using System;

namespace _08.Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] beastArray = { "leviathan", "kraken", "bahamut", "ouroboros", "jormungandr" };
            
            Random rand = new Random();
            int randomIndex = rand.Next(0, 5);
            string[] hiddenChars = new string[beastArray[randomIndex].Length];
            string misses = "";
            var counter = 0;

            for (var i = 0; i < beastArray[randomIndex].Length; i++)
                hiddenChars[i] = " _";

            for (var k = 0; k < 15; k++)
            {
                Console.Clear();

                Console.WriteLine($"You have {15 - k} shots before reset.");
                Console.Write("Word: ");
                for (var o = 0; o < hiddenChars.Length; o++)
                    Console.Write(hiddenChars[o]);
                Console.WriteLine();

                Console.Write("Misses: " + misses);
                Console.WriteLine();

                Console.Write("Guess: ");
                if (counter == beastArray[randomIndex].Length)
                {
                    Console.WriteLine("You won!");
                    return;
                }
                char guess = Convert.ToChar(Console.ReadLine());

                bool missed = true;

                for (var j = 0; j < beastArray[randomIndex].Length; j++)
                {
                    if (guess == beastArray[randomIndex][j])
                    {
                        ++counter;
                        hiddenChars[j] = " " + Convert.ToString(guess);
                        missed = false;
                    }
                }
                if (missed)
                    misses += guess;
            }

            Console.ReadKey();
        }
    }
}
