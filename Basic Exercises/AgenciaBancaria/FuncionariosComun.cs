using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AgenciaBancaria
{
    class FuncionariosComun : Funcionarios
    {
        public override string Bonificacao()
        {
            Salario = Salario + ((Salario * 10) / 100.0);
            return base.Bonificacao()
                + "\nSalario: "
                + Salario.ToString("F2", CultureInfo.InvariantCulture)
                + "\n"; 
        }
    }
}
