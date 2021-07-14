using System;

namespace _07.isUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string name = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsUpper(name[i])) counter++;
            }


            Console.WriteLine($"Count of Uppercases is: {counter}");
            Console.ReadKey();
        }
    }
}