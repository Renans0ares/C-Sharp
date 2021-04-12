using System;
using System.Globalization;

namespace ExFixCap5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Insira o nome do Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n)");
            char res = char.Parse(Console.ReadLine());

            if(res == 's' || res == 'S')
            {
                Console.Write("Entre com o valo do deposito inicial: ");
                double depositoI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoI);
            }
            else
            {
                conta = new ContaBancaria(numero, titular, 0);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}
