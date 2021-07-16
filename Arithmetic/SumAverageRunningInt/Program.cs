using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) {
                sum += number;
            }
            Console.WriteLine($"The sum of 1 to 100 is {sum}");
            Console.WriteLine($"The average is {sum / upperBound}");
        }
    }
}
