using System;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Min? ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max? ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[max - min + 1];

            for (var i = 0; i <= max - min; i++)
            {
                array[i] = min + i;
                Console.Write(array[i]);
            }

            for (var k = 0; k < max - min; k++)
            {
                Console.WriteLine();

                for (var j = 0; j <= max - min; j++)
                {
                    array[j] += 1;
                    if (array[j] > max)
                        array[j] = min;
                    Console.Write(array[j]);
                }
            }
            
            Console.ReadKey();
        }
    }
}
