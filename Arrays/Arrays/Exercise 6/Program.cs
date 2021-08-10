using System;

namespace Exercise_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetRndNumArray();
            int[] newArray = GetChangedArray(array);
            

            Console.Write("Array 1:");
            for (var i = 0; i < 10; i++)
            {
                Console.Write(" " + newArray[i]);
            }
            
            Console.WriteLine();
            Console.Write("Array 2:");
            for (var j = 0; j < 10; j++)
                Console.Write(" " + array[j]);

            Console.ReadKey();
        }

        public static int[] GetRndNumArray()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (var i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(100);
            }

            return array;
        }

        public static int[] GetChangedArray(int[] array)
        {
            int[] newArray = new int[10];
            for (var k = 0; k < newArray.Length; k++)
            {
                newArray[k] = array[k];
            }

            newArray[9] = -7;
            return newArray;
        }
    }
}
