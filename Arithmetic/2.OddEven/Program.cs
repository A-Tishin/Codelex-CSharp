using System;
using System.ComponentModel.Design;

namespace OddEven
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number, to check if odd or even: ");
            int oddEven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckOddEven(oddEven) ? "It's Even" : "It's Odd.");
            Console.WriteLine("Bye!");
        }

        public static bool CheckOddEven(int number)
        {
            bool odd = number % 2 == 0;
            return odd;
        }
    }
}
