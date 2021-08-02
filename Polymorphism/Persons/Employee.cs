using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Employee: Person
    {
        private string _jobTitle;

        public Employee(string name, string lastName, string adress, int id, string job)
            : base(name, lastName, adress, id)
        {
            _jobTitle = job;
        }

        public string Job => _jobTitle;

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, lives at {Adress}, works as {Job}. ID: {Id}");
        }
    }
}
