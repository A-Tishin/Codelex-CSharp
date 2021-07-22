using System.Collections.Generic;

namespace MovieExercise4
{
    class Movie
    {
        public string title;
        public string studio;
        public string rating;

        public Movie(string title, string studio, string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie(string title, string studio)
        {
            this.title = title;
            this.studio = studio;
            rating = "PG";
        }

        public static List<Movie> GetPG(Movie[] arr)
        {
            List<Movie> pgArray = new List<Movie>();
            foreach (var i in arr)
            {
                if (i.rating == "PG")
                {
                    pgArray.Add(i);
                }
            }

            return pgArray;
        }
    }
}
