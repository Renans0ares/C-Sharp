using System;

namespace ExemploStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p); //(10, 20)

            p = new Point();
            Console.WriteLine(p); //(0, 0)
        }
    }
}
