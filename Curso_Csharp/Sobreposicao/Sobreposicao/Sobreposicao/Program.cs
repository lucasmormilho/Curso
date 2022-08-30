using System;
using Sobreposicao.Entities;

namespace Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Lucas", 500.0);

            //upcasting
            Account acc2 = new SavingsAccount(1002, "Bob", 500.0, 0.01);

            acc1.Withdraw(10.0); //withdraw do account
            acc2.Withdraw(10.0); //withdraw do savingsaccount override

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
