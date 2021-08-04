using System;

namespace CalculateArea
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = getMenu();

                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("What is the circle's radius? ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The circle area is: " + calculateCircleArea(radius));
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter length? ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width? ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of this rectangle is: " + calculateRectangleArea(length, width));
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter length of the triangle's base? ");
                    double ground = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter triangle's height? ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of this triangle is: " + calculateTriangleArea(ground, height));
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

        public static double calculateCircleArea(double radius)
        {
            double rad = Math.Round((Math.PI * radius * 2), 2);
            return rad;
        }

        public static double calculateRectangleArea(double length, double width)
        {
            return Math.Round((length * width), 2);
        }

        public static double calculateTriangleArea(double ground, double height)
        {
            return Math.Round(((ground * height) / 2), 2);
        }
    }
}
