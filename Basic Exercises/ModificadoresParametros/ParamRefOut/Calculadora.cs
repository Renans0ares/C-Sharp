using System;
using System.Collections.Generic;
using System.Text;

namespace ParamRefOut
{
    class Calculadora
    {
        public static void Triplo(ref int x) //Com a palavra ref é possivle realizar a mudança não no escopo da função,
                                            //Mas na referencia do A
        {
            x = x * 3;
        }

        public static void Dobro(int origem, out int resultado)
        {
            resultado = origem * 2;
        }
    }
}
