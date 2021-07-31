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

        public override void MakeSound()
        {
            Console.WriteLine("ps ps");
        }

        public override void Eat(Food food)

        {
            if (food.GetFoodType() != "Vegetables")
            {
                Console.WriteLine($"{animalType} are not eating that type of food!");
            }
            else
            {
                foodEaten = food.quantity;
                Console.WriteLine($"{animalType}, {animalName}, {animalWeight}, {livingRegion}, {foodEaten}");
            }
        }

        public override string ToString()
        {
            return $"{animalType}, [{animalName}, {animalWeight}, {livingRegion}, {foodEaten}] ";
        }
    }
}
