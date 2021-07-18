using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            int weight = Convert.ToInt32(Console.ReadLine()) ;
            Console.Write("And height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            double kilosToPounds = 2.20462;
            double cmToInches = 0.393701;
            double bmi = Math.Round((weight * kilosToPounds) * 703 / Math.Pow(height * cmToInches, 2), 2);

            if (bmi < 18.5)
                Console.WriteLine(($"Your BMI is {bmi}, indicating your weight is in the underweight category."));
            else if (bmi >= 25)
                Console.WriteLine($"Your BMI is {bmi}, indicating your weight is in the overweight category.");
            else
                Console.WriteLine($"Your BMI is {bmi}, indicating your weight is in the normal category.");
        }
    }
}
