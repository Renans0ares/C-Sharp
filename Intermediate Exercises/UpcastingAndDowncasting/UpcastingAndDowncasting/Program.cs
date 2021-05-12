using System;
using UpcastingAndDowncasting.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Renan", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Carlos", 0.0, 700.0);

            //UPCASTING

            Account acc1 = bacc; //O bussiness account é uma account
            Account acc2 = new BusinessAccount(1003, "Giovanni", 0.0, 200.0);
            Account acc3 = new SavingsAccounts(1004, "Thiago", 0.0, 0.01);

            //DOWNCASTING -- Inseguro

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if(acc3 is SavingsAccounts)
            {
                SavingsAccounts acc5 = (SavingsAccounts)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("UPDATE!");
            }
        }
    }
}