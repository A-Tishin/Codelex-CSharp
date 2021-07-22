namespace FuelgaugeAndOdo
{
    class FuelGauge
    {
        public int Liters;
        private const int MinLevel = 0;
        private const int MaxLevel = 70;

        public int GetLiters()
        {
            return Liters;
        }

        public void Fill()
        {
            do
            {
                Liters++;
            } while (Liters < MaxLevel);
        }

        public void Burn()
        {
            if (Liters > MinLevel)
                Liters--;
        }
    }
}
