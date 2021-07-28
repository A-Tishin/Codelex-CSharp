using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            var namesHash = new HashSet<string>();
            var input = "";
            do
            {
                Console.Write("Enter name: ");
                input = Console.ReadLine();
                namesHash.Add(input);
            } while (input != "");

            string output = "Unique name list contains:";

            foreach (var name in namesHash)
            {
                output += " " + name;
            }

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
