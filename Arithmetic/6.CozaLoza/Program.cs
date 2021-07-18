using System;

namespace CozaLoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 110; i++)
            {
                var temp = " ";

                if (i % 3 == 0)
                    temp += "Coza";
                if (i % 5 == 0)
                    temp += "Loza";
                if (i % 7 == 0)
                    temp += "Woza";
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                    Console.Write($" {i}");

                Console.Write(temp);

                if (i % 11 == 0)
                    Console.WriteLine();
            }
        }
    }
}
