using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao.Entities
{
    class SavingsAccounts : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccounts()
        {
        }

        public SavingsAccounts(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) //Reesrever com outro comportamento
        {
            //Balance -= amount;
            //Outro exemplo
            base.Withdraw(amount);//Operacao de saque na superclasse
            Balance -= 2.0;

        }
    }
}
