using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AgenciaBancaria
{
    class Diretor : Funcionarios
    {
        public string Relatorios { get; set; }
        public int GerSubor { get; set; }

        public override string Bonificacao()
        {
            Salario = Salario + ((Salario * 20) / 100.0);
            return base.Bonificacao()
                + "\nSalario:"
                + Salario.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPossue " 
                + GerSubor 
                + " gerentes subordinados com o relatório para " 
                + Relatorios 
                + " em mãos.\n";
        }


    }
}
