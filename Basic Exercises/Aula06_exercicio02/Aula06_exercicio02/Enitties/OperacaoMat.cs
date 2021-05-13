using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06_exercicio02.Enitties
{
    abstract class OperacaoMat
    {
        public int PrimeiroNum { get; set; }
        public int SegundoNumero { get; set; }

        public abstract double Calcular();
    }
}
