using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balane { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balane)
        {
            Number = number;
            Holder = holder;
            Balane = balane;
        }

        public void Withdraw(double amount)
        {
            Balane -= amount;
        }

        public void Deposit(double amount)
        {
            Balane += amount;
        }
    }
}
