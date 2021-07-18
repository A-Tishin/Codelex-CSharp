using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = getMenu();

                if (choice == 1)
                {
                    calculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    calculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    calculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {
            int userChoice;
            Console.Clear();
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                return keyboard.KeyChar;
            }

            return userChoice;
        }

        public static void calculateCircleArea()
        {
            var keyboard = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What is the circle's radius? ");
            double radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The circle's area is " + (Math.PI * radius * 2));
        }

        public static void calculateRectangleArea()
        {
            var keyboard = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter length? ");
            decimal length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width? ");
            decimal width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The rectangle's area is " + length * width);
        }

        public static void calculateTriangleArea()
        {
            var keyboard = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter length of the triangle's base? ");
            decimal ground = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter triangle's height? ");
            decimal height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The triangle's area is " + (ground * height) / 2);
        }
    }
}
