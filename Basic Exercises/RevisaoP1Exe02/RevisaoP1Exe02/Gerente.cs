using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoP1Exe02
{
    public class Gerente : Funcionario
    {
        protected double senha { get; set; }
        protected int numero_funcionarios { get; set; }

        public Gerente(string n, string cpf, double salario, double senha, int num) : base()
        {
            this.nome = n;
            this.cpf = cpf;
            this.salario = salario;
            this.senha = senha;
            this.numero_funcionarios = num;
        }
        public override double bonificacao()
        {
            return this.salario * 0.15;
        }

        public override void imprimeDados()
        {
            base.imprimeDados();
            Console.WriteLine("Senha = " + this.senha +
                "\nNúmero de Funcionario = " + this.numero_funcionarios);
            
        }
    }
}
