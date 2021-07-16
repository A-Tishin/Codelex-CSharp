using System;

namespace _4.Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod = 1;
            for (int i = 1; i <= 10; i++)
            {
                prod *= i;
            }
            Console.WriteLine($"{prod}");
        }
    }
}
