using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06_exercicio02.Enitties
{
    class Multiplicacao : OperacaoMat
    {
        public override double Calcular()
        {
            return PrimeiroNum * SegundoNumero;
        }
    }
}
