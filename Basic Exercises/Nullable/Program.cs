using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); //0
            Console.WriteLine(y.GetValueOrDefault()); //10

            Console.WriteLine(x.HasValue); //False
            Console.WriteLine(y.HasValue); //True

            //Console.WriteLine(x.Value); Não imprime simplesmente

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é NULL");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é NULL");
            }


            double? a = null;
            double b = a ?? 5;

            Console.WriteLine(b);


            
        }
    }
}
