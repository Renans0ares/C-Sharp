using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoP1Exe02
{
    public abstract class Funcionario
    {
        protected string nome { get; set; }
        protected string cpf { get; set; }
        protected double salario { get; set; }

        public virtual void imprimeDados()
        {
            Console.WriteLine("Nome = " + this.nome +
                "\nCPF = " + this.cpf +
                "\nSalário = " + this.salario);
        }

        public abstract double bonificacao();
    }
}
