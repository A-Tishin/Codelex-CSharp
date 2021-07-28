using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> valueList = new List<string>();

            for (var i = 1; i <= 10; i++)
            {
                valueList.Add("A" + i);
            }

            valueList.Insert(4, "B");
            valueList[valueList.Count - 1] = "C";
            valueList.Sort();
            Console.WriteLine("Foobar? " + valueList.Contains("Foobar"));

            foreach (var value in valueList)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
