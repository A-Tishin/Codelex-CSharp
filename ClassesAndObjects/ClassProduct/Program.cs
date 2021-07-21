using System;
using System.Runtime.InteropServices;
using ClassProduct1;

namespace ClassProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", (decimal)70.00, 14);
            Product iphone = new Product("Iphone", (decimal)999.99, 3);
            Product printer = new Product("Epson EB-U05", (decimal)440.46, 1);

            mouse.PrintProduct();
            iphone.PrintProduct();
            printer.PrintProduct();

            Console.WriteLine("Please, make mouse cheaper.");
            mouse.NewPrice(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("And buy it!(y)");

            if (Console.Read() == 'y')
            {
                mouse.NewQuantity();
            }

            mouse.PrintProduct();
        }
    }
}
