using System;

namespace IsFifteen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool isFifteen = IsFifteen(num1, num2);
            Console.WriteLine($"Those two are different, sum or either one of them equals 15 ? {isFifteen}");
        }

        public static bool IsFifteen(int num1, int num2)
        {
            bool fifteen = num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15;
            return fifteen;
        }
    }
}