using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<ISound>() {new Firework(), new Parrot(), new Radio()};
            foreach (var sound in list)
            {
                sound.PlaySound();
            }

            Console.ReadKey();
        }
    }
}