using System;
using System.Globalization;
namespace ConstrutorExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);
                
            Produto p2 = new Produto();

            Produto p3 = new Produto()
            {
                Nome = "TV",
                Preco = 500.0,
                Quantidade = 10
            };


        }
    }
}