using System;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            float sum = 0;

            foreach (var elem in numbers)
                sum += elem;

            Console.WriteLine($"Sum of the array is: {sum}");
            Console.WriteLine($"Average value of the array elements is: {(sum / numbers.Length)}");
            Console.ReadKey();
        }
    }
}
