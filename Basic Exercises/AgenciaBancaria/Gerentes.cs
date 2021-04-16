using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AgenciaBancaria
{
    class Gerentes : Funcionarios
    {
        public string Senha { get; set; }
        public int TeamLead { get; set; }

        public override string Bonificacao()
        {
            Salario = Salario + ((Salario * 15) / 100.0);
            return base.Bonificacao()
                + "\nSalario:"
                + Salario.ToString("F2", CultureInfo.InvariantCulture)
                + "\nGerencia "
                + TeamLead 
                + " pessoas\n";
        }

    }
}
