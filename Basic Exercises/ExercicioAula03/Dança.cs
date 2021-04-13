using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula03
{
    public abstract class Danca
    {
        public string PaisDeOrigem { get; set; }
        public string DescricaoPassos { get; set; }

        public virtual string Dancar()
        {
            return "O País de origem é " + PaisDeOrigem + " com passos de " + DescricaoPassos;
        }
    }
}
