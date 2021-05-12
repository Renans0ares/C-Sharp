using System;
using Herança.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Renan soares", 100.0, 500.0);

            Console.WriteLine(account);
        }
    }
}
