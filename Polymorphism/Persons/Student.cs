using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Student: Person
    {
        private double _gpa;

        public Student(string name, string lastName, string adress, int id, double gpa)
            : base(name, lastName, adress, id)

        {
            _gpa = gpa;
        }

        public double Gpa => _gpa;

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, lives at {Adress}, have {Gpa} points. ID: {Id}");
        }
    }
}
