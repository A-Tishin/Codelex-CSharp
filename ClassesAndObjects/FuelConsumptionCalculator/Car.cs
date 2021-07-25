using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _kilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _kilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return Math.Round(_liters / _kilometers * 100, 2);
        }
        
        public bool GasHog()
        {
            return CalculateConsumption() >= 15;
        }

        public bool EconomyCar()
        {
            return CalculateConsumption() <= 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _kilometers += mileage;
            _liters += liters;
        }
    }
}
