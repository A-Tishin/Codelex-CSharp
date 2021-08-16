using System;
using System.Linq;

namespace Scooty
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalCompany scooty = new RentalCompany("Scooty");
            FillWithScooters(scooty);
            PrintScooterList(scooty);
            Console.WriteLine("Total income: " + scooty.CalculateIncome(CheckInputForCalcIncome(scooty), true));
        }

        public static void FillWithScooters(RentalCompany company)
        {
            for (var i = 1; i < 10; i++)
            {
                company.AddScooter(i.ToString(), .20m + ((decimal)i / 100));
            }
        }

        public static void PrintScooterList(RentalCompany scooty)
        {
            var input = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Enter scooter ID to start rent session, 'e' to Exit, i to calculate income.");
                foreach (var scooter in scooty.GetScooters())
                {
                    Console.WriteLine(
                        $"ID: {scooter.Id} | PPM: {scooter.PricePerMinute} | Is rented: {scooter.IsRented}");
                }

                input = Console.ReadLine();
                if (input != "e" && input != "i")
                {
                    if (scooty.GetScooterById(input).IsRented)
                    {
                        scooty.EndRent(input, DateTime.Now);
                        continue;
                    }

                    scooty.StartRent(input);
                }

            } while (input != "e" && input != "i");
        }

        public static int? CheckInputForCalcIncome(RentalCompany scooty)
        {
            int? year = null;
            Console.WriteLine("Enter year to get yearly or nothing to get full report.");
            var a = Console.ReadLine();
            var b = 0;
            if (!string.IsNullOrEmpty(a))
            {
                b = Convert.ToInt32(a);
            }
            if (scooty.accountant.reports.ContainsKey(b))
            {
                year = b;
            }

            return year;
        }
    }
}
