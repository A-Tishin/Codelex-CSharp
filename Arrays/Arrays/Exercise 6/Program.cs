using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] newArray = new int[10];
            Random rnd = new Random();

            for (var i = 0; i < 10; i++)
                array[i] = rnd.Next(100);

            for (var k = 0; k < newArray.Length; k++)
                newArray[k] = array[k];

            array[9] = -7;
            Console.Write("Array 1:");

            for (var i = 0; i < array.Length; i++)
                Console.Write(" " + array[i]);

            Console.WriteLine();
            Console.Write("Array 2:");

            for (var j = 0; j < newArray.Length; j++)
                Console.Write(" " + newArray[j]);

            Console.ReadKey();
        }
    }
}
