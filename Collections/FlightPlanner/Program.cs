using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Program
    {
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var routes = GetRoutes(readText);
            var cities = GetCities(readText).ToList();
            Console.WriteLine(MakeTrip(routes, cities));
            Console.ReadKey();
        }

        public static string MakeTrip(Dictionary<string, List<string>> routes, List<string> cities)
        {
            Console.WriteLine("Choose your starting point: ");
            PrintCities(cities);
            string startingPoint = cities[Convert.ToInt32(Console.ReadLine()) - 1];
            string point = startingPoint;
            string journey = startingPoint;
            do
            {
                Console.Clear();
                Console.WriteLine(journey);
                Console.WriteLine($"You are in {point}");
                var flightTo = routes[point];
                PrintCities(flightTo);
                point = flightTo[Convert.ToInt32(Console.ReadLine()) - 1];
                journey += " -> " + point;
            } while (startingPoint != point);

            Console.Clear();
            return journey;
        }

        public static void PrintCities(List<string> cities)
        {
            int counter = 1;
            foreach (var city in cities)
            {
                Console.WriteLine($"{counter}. {city}");
                counter++;
            }
        }

        public static Dictionary<string, List<string>> GetRoutes(string[] text)
        {
            var routes = new Dictionary<string, List<string>>();
            foreach (var s in text)
            {
                string[] city = s.Split('-', '>');
                for (var i = 0; i < 3; i++)
                {
                    city[i] = city[i].Trim();
                }

                if (routes.ContainsKey(city[0]))
                {
                    routes[city[0]].Add(city[2]);
                }
                else
                {
                    routes.Add(city[0], new List<string>() { city[2] });
                }
            }

            return routes;
        }

        public static HashSet<string> GetCities(string[] text)
        {
            var cities = new HashSet<string>();
            foreach (var c in text)
            {
                string[] route = c.Split('-');
                cities.Add(route[0].Trim());
            }

            return cities;
        }
    }
}
