using System;
using System.Collections.Generic;

namespace MovieExercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public static List<Movie> GetPG(Movie[] arr)
        {
            List<Movie> pgArray = new List<Movie>();
            foreach (var i in arr)
            {
                if (i._rating.Contains("PG"))
                {
                    pgArray.Add(i);
                }
            }

            return pgArray;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"{_title} is {_rating} rated.");
        }
    }
}
