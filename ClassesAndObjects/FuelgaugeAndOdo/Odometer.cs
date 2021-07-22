namespace FuelgaugeAndOdo
{
    class Odometer
    {
        private int _mileage;
        private int _maxMileage = 999999;
        private FuelGauge _fuelGauge;
        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }

        public int Getmileage()
        {
            return _mileage;
        }

        public void Drive()
        {
            if (_mileage < _maxMileage)
            {
                _mileage++;
                BurnLiters();
            }
            else
            {
                _mileage = 0;
                BurnLiters();
            }
        }

        public void BurnLiters()
        {
            if (_mileage % 10 == 0)
            {
                _fuelGauge.Burn();
            }
        }
    }
}
