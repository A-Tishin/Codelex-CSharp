using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
     public abstract class Animal
     {
         public string animalName;
         public string animalType;
         public double animalWeight;
         public int foodEaten = 0;

         protected Animal(string animalType, string animalName, double animalWeight)
         {
             this.animalType = animalType;
             this.animalName = animalName;
             this.animalWeight = animalWeight;
         }

         public abstract string MakeSound();

         public abstract string ToString();

         public abstract string Eat(Food food);
     }
}
