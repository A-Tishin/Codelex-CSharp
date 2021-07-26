using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla" };
            var list = new List<string>() {"Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla"};
            var hashSet = new HashSet<string>() {"Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla"};
            var dictionary = new Dictionary<string, string>
            {
                {"Audi", "Germany"},
                {"BMW", "Germany"},
                {"Honda", "Japan"},
                {"Mercedes", "Germany"},
                {"Volkswagen", "Germany"},
                {"Tesla", "USA"}
            };

            foreach (var car in list)
            {
                Console.Write($"{car}, ");
            }

            Console.WriteLine();

            foreach (var car in hashSet)
            {
                Console.Write($"{car}, ");
            }

            Console.WriteLine();

            foreach (var car in dictionary)
            {
                Console.WriteLine($"{car.Key} from {car.Value}");
            }

            Console.ReadKey();
        }
    }
}
