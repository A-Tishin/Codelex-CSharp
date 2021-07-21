using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return Math.Round((_liters / (_endKilometers - _startKilometers) * 100), 2);
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
            _endKilometers = mileage;
            _liters = liters;
        }
    }
}
