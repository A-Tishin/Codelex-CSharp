using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "Male");
            Dog rocky = new Dog("Rocky", "Male");
            Dog sparky = new Dog("Sparky", "Male");
            Dog buster = new Dog("Buster", "Male");
            Dog sam = new Dog("Sam", "Male");
            Dog lady = new Dog("Lady", "Female");
            Dog molly = new Dog("Molly", "Female");
            Dog coco = new Dog("Coco", "Female");

            max.mom = lady;
            max.dad = rocky;
            coco.mom = molly;
            coco.dad = buster;
            rocky.mom = molly;
            rocky.dad = sam;
            buster.mom = lady;
            buster.dad = sparky;

            Console.WriteLine(coco.DadName());
            Console.WriteLine(sparky.DadName());
            Console.WriteLine(coco.HasSameMotherAs(rocky));
            Console.WriteLine(buster.HasSameMotherAs(coco));

            Console.ReadKey();
        }
    }
}
