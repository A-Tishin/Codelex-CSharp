using System;

namespace LargestNumber
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();
            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());
            int largest = Convert.ToInt32(input1);

            if (input2 > largest && input3 < input2)
                largest = input2;
            else if (input3 > largest)
                largest = input3;

            Console.WriteLine($"Largest is {largest}");
            Console.ReadKey();
        }
    }
}
