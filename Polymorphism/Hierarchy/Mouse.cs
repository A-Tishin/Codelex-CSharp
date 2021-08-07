using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Mouse: Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight, livingRegion) {}

        public override string MakeSound()
        {
            return "ps ps";
        }

        public override string Eat(Food food)

        {
            if (food.GetFoodType() != "Vegetables")
            {
                return $"{animalType} are not eating that type of food!";
            }

            foodEaten = food.quantity;
            return $"{animalType}, {animalName}, {animalWeight}, {livingRegion}, {foodEaten}";
        }

        public override string ToString()
        {
            return $"{animalType}, [{animalName}, {animalWeight}, {livingRegion}, {foodEaten}] ";
        }
    }
}
