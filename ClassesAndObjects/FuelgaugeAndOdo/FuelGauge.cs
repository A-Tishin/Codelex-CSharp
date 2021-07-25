namespace FuelgaugeAndOdo
{
    class FuelGauge
    {
        public int Liters;
        private const int _minLevel = 0;
        private const int _maxLevel = 70;

        public int GetLiters()
        {
            return Liters;
        }

        public void Fill()
        {
            do
            {
                Liters++;
            } while (Liters < _maxLevel);
        }

        public void Burn()
        {
            if (Liters > _minLevel)
            {
                Liters--;
            }
        }
    }
}
