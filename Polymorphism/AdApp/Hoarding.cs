using System.Runtime.InteropServices.ComTypes;

namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        //per day
        private int _numDays;
        private bool _isPrime;
        private double _primeRate = 1.5;

        public Hoarding(int fee, int days, int rate, bool isPrime) : base(fee)
        {
            _rate = rate;
            _numDays = days;
            _isPrime = isPrime;
        }

        public override double Cost() 
        {
            if (_isPrime)
            {
                return base.Cost() + _numDays * _rate * _primeRate;
            }

            return base.Cost() + _numDays * _rate;
        }

        public override string ToString()
        {
            return "Hoarding price: " + Cost();
        }
    }
}