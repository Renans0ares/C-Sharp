using System;
using System.Globalization;

namespace Vetor02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vet[i] = new Produto { Name = name, Preco = preco };
            }

            double soma = 0.0;

            for(int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;
            }

            double total = soma / n;

            Console.WriteLine("Preço Médio = " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
