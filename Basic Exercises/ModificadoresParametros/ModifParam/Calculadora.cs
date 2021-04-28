using System;
using System.Collections.Generic;
using System.Text;

namespace ModifParam
{
    class Calculadora
    {
        public static int Soma(params int[] num)
        {
            int soma = 0;

            for (int i = 0; i < num.Length; i++)
            {
                soma += num[i];
            }
            return soma;
        }
    }
}
