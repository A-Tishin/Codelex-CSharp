namespace AdApp
{
    public class TVAd: Advert
    {
        private int _pricePerSecond;
        private int _showTime;
        private bool _isPeakTime;
        private double _peakTimeRate = 2;
        public TVAd(int fee, int pricePerSecond, int showTime, bool isPeakTime) : base(fee)
        {
            _pricePerSecond = pricePerSecond;
            _showTime = showTime;
            _isPeakTime = isPeakTime;
        }
        
        public override double Cost() 
        {
            if (_isPeakTime)
            {
                return base.Cost() + _pricePerSecond * _showTime * _peakTimeRate;
            }
            return base.Cost() + _pricePerSecond * _showTime;
        }

        public override string ToString()
        {
            return "TV commercial price: " + Cost();
        }
    }
}