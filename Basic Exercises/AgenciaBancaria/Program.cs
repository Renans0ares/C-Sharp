using System;
using System.Globalization;

namespace AgenciaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionariosComun funC = new FuncionariosComun();
            funC.Nome = "Renan Soares";
            funC.CPF = 11882098205;
            funC.Salario = 2585.72;

            Gerentes funG = new Gerentes();
            funG.Nome = "Carlos Augusto";
            funG.CPF = 451387935435;
            funG.Salario = 10785.15;
            funG.Senha = "1050TI";
            funG.TeamLead = 8;


            Diretor funD = new Diretor();
            funD.Nome = "Giovanni Trintinalia";
            funD.CPF = 6954721358;
            funD.Salario = 29837.55;
            funD.Relatorios = "demitir o Thiago";
            funD.GerSubor = 5;


            Console.WriteLine(funC.Bonificacao());
            Console.WriteLine(funG.Bonificacao());
            Console.WriteLine(funD.Bonificacao());






        }
    }
}
