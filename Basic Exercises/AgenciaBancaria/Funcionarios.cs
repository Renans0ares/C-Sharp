using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaBancaria
{
    public abstract class Funcionarios
    {
        public string Nome { get; set; }
        public double CPF { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }


        public virtual string Bonificacao()
        {
            return "Nome: "
                + Nome
                + "\nCPF: "
                + CPF;
        }

    }
}
