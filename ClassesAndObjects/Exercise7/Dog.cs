using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        public Dog mom;
        public Dog dad;

        public Dog(string name, string sex) 
        {
            _name = name;
            _sex = sex;
        }

        public string DadName()
        {
            if (dad == null)
            {
                return "Unknown";
            }

            return dad._name;
        }

        public bool HasSameMotherAs(Dog cousin)
        {
            if (mom._name == cousin.mom._name)
            {
                return true;
            }

            return false;
        }
    }
}
