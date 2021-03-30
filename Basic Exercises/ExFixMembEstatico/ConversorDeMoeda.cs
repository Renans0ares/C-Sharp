using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixMembEstatico
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double ValorReias(double cotacao, double qtdD)
        {
            double total = cotacao * qtdD;

            return total + total * IOF / 100.0;
        }
    }
}
