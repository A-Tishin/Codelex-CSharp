using System;

namespace FooCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] employees = {7.50, 8.20, 10, 00};
            double[] hours = {35, 47, 73};

            for (var i = 0; i < employees.Length; i++)
            {
                if (hours[i] > 40 && hours[i] < 61 && employees[i] > 8)
                    Console.WriteLine($"{40 * employees[i] + ((hours[i] - 40) * employees[i] * 1.5)}");
                else if (hours[i] < 40 && employees[i] > 8)
                    Console.WriteLine($"{employees[i] * hours[i]}");
                else
                    Console.WriteLine("Error! Too many hours or too small salary per hour.");
            }
        }
    }
}
