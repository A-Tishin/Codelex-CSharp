using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    abstract class Mammal: Animal
    {
        public string livingRegion;

        protected Mammal(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight)
        {
            this.livingRegion = livingRegion;
        }
    }
}
