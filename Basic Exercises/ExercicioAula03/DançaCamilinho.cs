using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula03
{
    class DancaCamilinho : Danca
    {
        public string Relatorio { get; set; }

        public override string Dancar()
        {
            return base.Dancar() + "\nCom o Seguinte relatório: " + Relatorio;
        }
    }
}
