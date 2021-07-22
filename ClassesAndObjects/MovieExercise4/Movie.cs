using System.Collections.Generic;

namespace MovieExercise4
{
    class Movie
    {
        private string title;
        private string studio;
        private string rating;

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

        public string[] GetPG(string[] arr)
        {
            List<string> pgArray = new List<string>();
            foreach (var i in arr)
            {
                
            }
        }
    }
}
