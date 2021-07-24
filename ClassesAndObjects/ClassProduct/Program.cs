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
            Product iphone = new Product("Iphone 5s", (decimal)999.99, 3);
            Product printer = new Product("Epson EB-U05", (decimal)440.46, 0);
            mouse.PrintProduct();
            iphone.PrintProduct();
            printer.PrintProduct();
            Console.Write("Yesterday Tim Cook presented new Iphone 13, so we need to make a discount for 5s. Pls, enter the new price: ");
            iphone.NewPrice(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Uh oh, our sales is growing up!");
            mouse.Sold();
            printer.Supply(5);
            printer.Sold();
            mouse.PrintProduct();
            iphone.PrintProduct();
            printer.PrintProduct();
        }
    }
}
