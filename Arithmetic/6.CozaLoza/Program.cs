using System;
using System.Security.Cryptography.X509Certificates;

namespace CozaLoza
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 110; i++)
            {
                Console.Write(" " + CozaLoza(i));
                if (i % 11 == 0)
                    Console.WriteLine();
            }
        }

        public static string CozaLoza(int i)
        {
            var temp = "";

            if (i % 3 == 0)
                temp += "Coza";
            if (i % 5 == 0)
                temp += "Loza";
            if (i % 7 == 0)
                temp += "Woza";
            if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                temp += $"{i}";

            return temp;
        }
    }
}
