using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Cat: Felime
    {
        private string _breed;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            _breed = breed;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string Eat(Food food)
        {
            foodEaten = food.quantity;
            return $"{animalType}, [{animalName}, {_breed}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }

        public override string ToString()
        {
            return $"{animalType}, [{animalName}, {_breed}, {animalWeight}, {livingRegion}, {foodEaten}] ";
        }
    }
}
