using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _inStore = true;
        private List<double> _ratingList = new List<double>();
        public Video(string title)
        {
            _title = title;
        }

        public void BeingCheckedOut()
        {
            _inStore = false;
        }

        public void BeingReturned()
        {
            _inStore = true;
        }

        public void AddRating(double rating)
        {
            _ratingList.Add(rating);
        }

        public double AverageRating()
        {
            return _ratingList.Sum() / _ratingList.Count;
        }

        public bool Available()
        {
            return _inStore;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{_title} {AverageRating()} (Total rated: {_ratingList.Count}) {Available()}";
        }
    }
}
