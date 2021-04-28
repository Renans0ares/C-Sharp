using System;

namespace ParamRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //A tem que ser inciado por conta do ref
            int a = 10;
            Calculadora.Triplo(ref a);
            Console.WriteLine(a);

            int b = 10;
            int dobro;

            Calculadora.Dobro(b, out dobro); //Será criado do A e saírá o resultado no Dobro
            Console.WriteLine(dobro);
        }
    }
}
