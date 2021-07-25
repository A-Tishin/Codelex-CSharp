using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private static List<Video> _store = new List<Video>();

        public void AddVideo(string title)
        {
            _store.Add((new Video(title)));
        }
        
        public void Checkout(string title)
        {
            foreach (var i in _store)
            {
                if (title == i.Title)
                {
                    i.BeingCheckedOut();
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var i in _store)
            {
                if (title == i.Title)
                {
                    i.BeingReturned();
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var i in _store)
            {
                if (title == i.Title)
                {
                    i.AddRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (var i in _store)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
