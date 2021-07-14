using System;

namespace _05.NiceLittleTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string Border = "+------------------------------------------------------------+";
            string[] Classes =
            {
                "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II",
                "AP US History", "Business Computer Infomation Systems"
            };
            string[] Teachers =
            {
                "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James"
            };

            Console.WriteLine(Border);
            for (var i = 0; i < Classes.Length; i++)
            {
                string whiteSpaceClasses = "";
                string whiteSpaceTeachers = "";
                for (var j = 0; j < 37 - Classes[i].Length; j++)
                {
                    whiteSpaceClasses += " ";

                }

                for (var k = 0; k < 15 - Teachers[i].Length; k++)
                {
                    whiteSpaceTeachers += " ";
                }
                Console.WriteLine($"| {i + 1} |{whiteSpaceClasses}{Classes[i]} | {whiteSpaceTeachers}{Teachers[i]} |");
            }
            Console.WriteLine(Border);

            Console.ReadKey();
        }
    }
}