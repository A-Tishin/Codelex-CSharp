using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path).Split(' ');
            PrintHistogram(readText);
            Console.ReadKey();
        }

        static void PrintHistogram(string[] scores)
        {
            string alone = "  100: ";

            for (var i = 0; i < 10; i++)
            {
                string output = $"{i}0-{10 * i + 9}: ";
                if (i == 0)
                {
                    output = "00-09: ";
                }

                for (var j = 0; j < scores.Length; j++)
                {
                    if (Convert.ToInt32(scores[j]) > i * 10 && Convert.ToInt32(scores[j]) < i * 10 + 9)
                    {
                        output += "*";
                    }
                    else if (Convert.ToInt32(scores[j]) == 100 && i == 9)
                    {
                        alone += '*';
                    }
                }
                Console.WriteLine(output);
            }
            Console.WriteLine(alone);
        }
    }
}

