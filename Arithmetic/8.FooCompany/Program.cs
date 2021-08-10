using System;
using System.Globalization;
using _8.FooCompany;

namespace FooCompany
{
    public class Program
    {
        static void Main(string[] args)
        {
            var david = new Employee(7.50, 35);
            var alex = new Employee(8.20, 47);
            var inna = new Employee(10.00, 73);
            Console.WriteLine(CheckLegalityAndSalary(david));
            Console.WriteLine(CheckLegalityAndSalary(alex));
            Console.WriteLine(CheckLegalityAndSalary(inna));
        }

        public static string CheckLegalityAndSalary(Employee employee)
        {
            if (employee.salary < 8)
            {
                return "Error!";
            }
            else if (employee.workingHours > 60)
            {
                return "Error!";
            }
            else if (employee.workingHours > 40)
            {
                double salary = 40 * employee.salary + (employee.workingHours - 40) * employee.salary * 1.5;
                return salary.ToString();
            }
            else
            {
                double salary = employee.workingHours * employee.salary;
                return salary.ToString();
            }
        }
    }
}
