using System;

namespace RevisaoP1Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioComum f = new FuncionarioComum("José", "123456789", 2500);
            Gerente g = new Gerente("João", "987654321", 10000, 123, 150);
            Diretor d = new Diretor("Maria", "999999999", 15000, 8);

            f.imprimeDados();
            Console.WriteLine("---------------------");
            g.imprimeDados();
            Console.WriteLine("---------------------");
            d.imprimeDados();
            Console.WriteLine("---------------------");

            Console.WriteLine("Bonificação do Funcionário Comum = R$" + f.bonificacao());
            Console.WriteLine("Bonificação do Gerente = R$" + g.bonificacao());
            Console.WriteLine("Bonificação do Diretor = R$" + d.bonificacao());


        }
    }
}
