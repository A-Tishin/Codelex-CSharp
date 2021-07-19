using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two words: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int dotSum = 30 - (input1.Length + input2.Length);

            Console.WriteLine(input1 + new string('.', dotSum)+ input2);
        }
    }
}
