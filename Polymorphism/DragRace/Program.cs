using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace DragRace
{
    class Program
    {
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
                } 
                else if (i == 3)
                {
                    foreach (var car in carList)
                    {
                        car.UseNitrousOxideEngine();
                    }
                } 
                else 
                {
                    foreach (var car in carList)
                    {
                        car.SpeedUp();
                    }
                }
            }
        }
    }
}