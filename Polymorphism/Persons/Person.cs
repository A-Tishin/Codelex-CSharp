using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        private int _id;

        protected Person(string name, string lastName, string adress, int id)
        {
            _firstName = name;
            _lastName = lastName;
            _adress = adress;
            _id = id;
        }

        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string Adress => _adress;
        public int Id => _id;

        public virtual void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName}, lives at {_adress}. ID: {_id}");
        }
    }
}
