using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS4", 3999.98, 2);

            p.Nome = "PS4 PRO";

            Console.WriteLine(p.Nome);


        }
    }
}
