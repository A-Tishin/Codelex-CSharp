using System;

namespace _06.SumOfSingles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers: ");
            string numbers = Console.ReadLine();
            numbers.Split("");
            int sum = 0;
            foreach (var num in numbers)
            {
                var temp = int.Parse(num.ToString());
                sum += temp;
            }
            Console.WriteLine($"The sum of singles is: {sum}");
        }
    }
}
