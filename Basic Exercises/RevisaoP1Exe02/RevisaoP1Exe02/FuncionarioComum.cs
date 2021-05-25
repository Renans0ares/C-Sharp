using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoP1Exe02
{
    public class FuncionarioComum : Funcionario
    {
        public FuncionarioComum (string n, string cpf, double salario) : base()
        {
            this.nome = n;
            this.cpf = cpf;
            this.salario = salario;
        }
        public override double bonificacao()
        {
            return this.salario * 0.1;
        }

        public override void imprimeDados()
        {
            base.imprimeDados();
        }
    }
}
