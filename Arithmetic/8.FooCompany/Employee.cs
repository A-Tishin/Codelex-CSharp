using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FooCompany
{
    public class Employee
    {
        public double salary;
        public int workingHours;

        public Employee(double salary, int hours)
        {
            this.salary = salary;
            workingHours = hours;
        }
    }
}
