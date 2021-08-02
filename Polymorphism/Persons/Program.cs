using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var aleksandrs = new Student("Aleksandrs", "Tisins", "Strautu iela", 164461, 25.85);
            var aleksandrsAfterThreeMonths = new Employee("Aleksandrs", "Tisins", "Darzciems", 156486, "Junior dev");
            aleksandrs.Display();
            aleksandrsAfterThreeMonths.Display();

            Console.ReadKey();
        }
    }
}