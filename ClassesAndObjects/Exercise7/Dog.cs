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
        private string _mom;
        private string _dad;

        public Dog(string name, string sex) 
        {
            _name = name;
            _sex = sex;
        }

        public string DadName()
        {
            if (_dad == null)
            {
                return "Unknown";
            }

            return _dad;
        }
    }
}
