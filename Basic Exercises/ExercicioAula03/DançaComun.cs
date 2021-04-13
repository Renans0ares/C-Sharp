using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula03
{
    class DancaComun : Danca
    {
        public string Ritmo { get; set; }

        public override string Dancar()
        {
            return base.Dancar() + " no Ritmo " + Ritmo;
        }
    }
}
