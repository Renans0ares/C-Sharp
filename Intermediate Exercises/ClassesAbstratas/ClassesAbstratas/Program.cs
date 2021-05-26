using System;
using System.Collections.Generic;
using ClassesAbstratas.Entities;
using System.Globalization;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccounts(1001, "Renan", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Carlos", 500.0,400.0));
            list.Add(new SavingsAccounts(1003, "Giovanni", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Yan", 500.0, 500.0));

            double sum = 0.0;

            foreach(Account count in list)
            {
                sum += count.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account count in list)
            {
                count.Withdraw(10.0);
            }

            foreach(Account count in list)
            {
                Console.WriteLine("Update balance for account "
                    + count.Number
                    + ": "
                    + count.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
