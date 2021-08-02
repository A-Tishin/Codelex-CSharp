using System;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            do
            {
                Console.Clear();
                var animal = Console.ReadLine().Split(" ").ToList();
                if (animal[0] == "Cat")
                {
                    var cat = new Cat(animal[0], animal[1],
                        Convert.ToDouble(animal[2]), animal[3], animal[4]);
                    animalList.Add(cat);
                } 
                else if (animal[0] == "Mouse")
                {
                    var mouse = new Mouse(animal[0], animal[1], Convert.ToDouble(animal[2]), animal[3]);
                    animalList.Add(mouse);
                } 
                else if (animal[0] == "Tiger")
                {
                    var tiger = new Tiger(animal[0], animal[1], Convert.ToDouble(animal[2]), animal[3]);
                    animalList.Add(tiger);
                } 
                else if (animal[0] == "Zebra")
                {
                    var zebra = new Zebra(animal[0], animal[1], Convert.ToDouble(animal[2]), animal[3]);
                    animalList.Add(zebra);
                }

                animalList.Last().MakeSound();
                string[] givenFood = Console.ReadLine().Split(" ");

                if (givenFood[0] == "Meat")
                {
                    animalList.Last().Eat(new Meat(Convert.ToInt32(givenFood[1])));
                } 
                else if (givenFood[0] == "Vegetable")
                {
                    animalList.Last().Eat(new Vegetable(Convert.ToInt32(givenFood[1])));
                }
                Console.WriteLine("Continue? y/n");
            } while (Console.ReadLine() != "n");

            foreach (var animal in animalList)
            {
                Console.Write(animal.ToString());
            }

            Console.ReadLine();
        }
    }
}