using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExFixCap5
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double  Saldo { get; private set; }

        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }
        public void Saque(double quantidade)
        {
            Saldo -= quantidade + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$"
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
