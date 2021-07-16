using System;

namespace _5.GuessRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I'm thinking of a number between 1-100.  Try to guess it.");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            var rand = new Random();
            int randomNum = (rand.Next(100));

            if (userGuess == randomNum)
                Console.WriteLine($"You guessed it!  What are the odds?!?");
            else if (userGuess > randomNum)
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {randomNum}");
            else
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {randomNum}");
        }
    }
}
