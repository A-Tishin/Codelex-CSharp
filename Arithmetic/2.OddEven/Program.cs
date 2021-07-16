using System;

namespace _2.OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number, to check if odd or even: ");
            int oddEven = Convert.ToInt32(Console.ReadLine());

            bool odd = oddEven % 2 == 1;

            Console.WriteLine(odd ? "It's Odd." : "It's Even");
            Console.WriteLine("Bye!");
        }
    }
}
