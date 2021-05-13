using System;
using Aula06_exercicio02.Enitties;

namespace Aula06_exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacaoMat[] operacaoMats = new OperacaoMat[5];

            operacaoMats[0] = new Soma();
            operacaoMats[1] = new Subtracao();
            operacaoMats[2] = new Divisao();
            operacaoMats[3] = new Multiplicacao();
            operacaoMats[4] = new Mod();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRACAO");
            Console.WriteLine("3 - DIVISAO");
            Console.WriteLine("4 - MULTIPLICACAO");
            Console.WriteLine("5 - RESTO DA DIVISAO");
            Console.Write("Escolha uma das opcoes acima: ");

            int op = int.Parse(Console.ReadLine());


            Console.Write("Informe o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            operacaoMats[op - 1].PrimeiroNum = n1;
            operacaoMats[op - 1].SegundoNumero = n2;

            Console.WriteLine("Resultado é " + operacaoMats[op - 1].Calcular());



        }
    }
}
