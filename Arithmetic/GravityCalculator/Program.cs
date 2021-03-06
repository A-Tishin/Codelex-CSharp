using System;

namespace GravityCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            const double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double initialPosition = 0.0;
            double fallingTime = Convert.ToDouble(Console.ReadLine());
            string finalPosition = CalcFinalPosition(gravity, initialVelocity, initialPosition, fallingTime);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }

        public static string CalcFinalPosition(double gravity, double initVelocity, double initPosition, double fallingTime)
        {
            if (initVelocity >= 0 && initPosition >= 0 && fallingTime >= 0)
            {
                double finalPosition = 0.5 * gravity * Math.Pow(fallingTime, 2) + initPosition + initVelocity * fallingTime;
                return finalPosition.ToString();
            }

            return "All data must be positive";
        }
    }
}
