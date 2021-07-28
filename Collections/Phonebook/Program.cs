using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneDirectory("Aleksandrs", "28354007");
            phoneBook.PutNumber("Aleksejs", "23658945");
            Console.WriteLine(phoneBook.GetNumber("Aleksandrs"));
            Console.WriteLine(phoneBook.GetNumber("Aleksejs"));

            Console.ReadKey();
        }
    }
}
