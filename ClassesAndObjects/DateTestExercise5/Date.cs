using System;

namespace DateTestExercise5
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day
        {
            get { return _day; }
            set
            {
                if (value < 1 || value > 31)
                {
                    Console.WriteLine("Day must be from 1 to 31.");
                    _day = 1;
                    return;
                }
                _day = value;
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    Console.WriteLine("We have only 12 months in year.");
                    _month = 1;
                    return;
                }

                _month = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value > 2021)
                {
                    _year = 2020;
                    return;
                }

                _year = value;
            }
        }

        public void PrintDate()
        {
            Console.WriteLine($"The formatted date of birth is: {_day}/{_month}/{_year}");
        }
    }
}
