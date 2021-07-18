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
            string dots = "";
            int dotSum = 30 - (input1.Length + input2.Length);

            for (var i = 0; i < dotSum; i++)
                dots += ".";
            Console.WriteLine(input1 + dots + input2);
        }
    }
}
