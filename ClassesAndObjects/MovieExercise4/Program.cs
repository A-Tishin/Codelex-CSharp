using System;
using System.Collections.Generic;

namespace MovieExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] array =
            {
                new("Casino Royale", "Eon Productions", "R"),
                new("Glass", "Buena Vista International", "PG13"),
                new("Spider-Man: Into the Spider-Verse", "Columbia Pictures")
            };

            List<Movie> pgArray = Movie.GetPG(array);

            foreach (var movie in pgArray)
            {
                Console.WriteLine($"{movie.title} is {movie.rating} rated." );
            }

            Console.ReadKey();
        }
    }
}
