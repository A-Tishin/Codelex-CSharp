using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            var carList = FillWithCars();
            StartRace(carList);
            string winner = "";
            int speed = 0;

            foreach (var car in carList)
            {
                if (car.GetCurrentSpeed() > speed)
                {
                    speed = car.GetCurrentSpeed();
                    winner = car.CarBrand;
                }
            }

            Console.WriteLine($"The winner is: {winner} with maximum speed of {speed}.");
        }

        static List<Car> FillWithCars()
        {
            var list = new List<Car>()
            {
                new Lexus("is350"), new Audi("A4"), new Tesla("model.3"),
                new Bmw("330i"), new Honda("Civic")
            };

            return list;
        }

        static void StartRace(List<Car> carList)
        {
            for (var i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    foreach (var car in carList)
                    {
                        car.StartEngine();
                    }
                } else if (i == 3)
                {
                    foreach (var car in carList)
                    {
                        car.UseNitrousOxideEngine();
                    }
                } else {
                    foreach (var car in carList)
                    {
                        car.SpeedUp();
                    }
                }
            }
        }
    }
}