using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            SwapPoint(p1, p2);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");

            static void SwapPoint(Point a, Point b)
            {
                Point temp = new Point(a.x, a.y);
                a.x = b.x;
                a.y = b.y;
                b.x = temp.x;
                b.y = temp.y;
            }

            Console.ReadKey();
        }
    }

    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
