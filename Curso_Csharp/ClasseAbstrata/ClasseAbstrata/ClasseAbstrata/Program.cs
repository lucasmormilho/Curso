using System;
using System.Globalization;
using System.Collections.Generic;
using ClasseAbstrata.Entities;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BussinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BussinessAccount(1004, "Ana", 500.0, 500.0));
            double sum = 0;
            foreach(Account item in list)
            {
                sum += item.Balance;
            }

            Console.WriteLine("Total balance: " 
                + sum.ToString("F2", CultureInfo.InvariantCulture));

            //----------------------------------------------------polimorfismo
            foreach(Account acc in list)
            {
                acc.Withdraw(10.0); //sacando 10 reais de cada conta
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("saldo atualizado da conta " 
                    +  acc.Number + " : " 
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
