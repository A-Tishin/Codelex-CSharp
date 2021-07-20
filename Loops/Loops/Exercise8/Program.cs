using System;

namespace Exercise8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of figure: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < input; i++)
            {
                string figure = "";
                for (var j = 1; j < input - i ; j++)
                    figure += "////";
                for (var l = 0; l < i; l++)
                    figure += "********";
                for (var k = 1; k < input - i ; k++)
                    figure += "\\\\\\\\";
                Console.WriteLine(figure);
            }

            Console.ReadKey();
        }
    }
}
