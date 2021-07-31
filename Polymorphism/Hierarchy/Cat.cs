using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Cat: Felime
    {
        private string _breed;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            _breed = breed;
        }
    }
}
