using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoP1Exe02
{
    public class Diretor : Funcionario
    {
        protected int numero_gerentes {get; set;}
        public Diretor(string n, string cpf, double salario, int num) : base()
        {
            this.nome = n;
            this.cpf = cpf;
            this.salario = salario;
            this.numero_gerentes = num;
        }
        public void geracao_relatorio()
        {
            Console.WriteLine("Geração de Relatório Permitido!");
        }

        public override double bonificacao()
        {
            return this.salario * 0.2;
        }

        public override void imprimeDados()
        {
            base.imprimeDados();
            Console.WriteLine("Número de Gerentes = " + this.numero_gerentes);
            this.geracao_relatorio();
        }
    }
}
