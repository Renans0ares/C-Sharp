using System;

namespace ModifParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar os vetores de uma forma mais compacta
            //int n1 = Calculadora.Soma(new int[] { 10, 25, 14 }); dá para ficar melhor

            //Utilizando Params
            int n1 = Calculadora.Soma(10, 25, 14);

            Console.WriteLine(n1);
        }
    }
}
