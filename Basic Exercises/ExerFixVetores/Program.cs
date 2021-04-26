using System;

namespace ExerFixVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensionato[] vet = new Pensionato[10];

            Console.Write("How many rooms will be rented? ");
            int cont = int.Parse(Console.ReadLine());

            for(int i = 1; i <= cont; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string _nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string _email = Console.ReadLine();
                Console.Write("Quarto: ");
                int _quarto = int.Parse(Console.ReadLine());

                vet[_quarto] = new Pensionato(_nome, _email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }


        }
    }
}