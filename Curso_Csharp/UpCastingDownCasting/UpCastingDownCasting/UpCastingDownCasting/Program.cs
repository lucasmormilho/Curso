using System;
using UpCastingDownCasting.Entities;

namespace UpCastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Lucas", 0.0);
            BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING
            Account acc1 = bacc; //account é bussinesAccount
            Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0);//account é bussinesAccount
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING (usar somente se necessario pois é inseguro)
            BussinessAccount acc4 = (BussinessAccount)acc2; //conversao explicita -casting
            acc4.Loan(100.0);

            //BussinessAccount acc5 = (BussinessAccount)acc3; //vai gerar um erro !!!

            //usar operador IS
            if (acc3 is BussinessAccount) 
            {
                //BussinessAccount acc5 = (BussinessAccount)acc3;
                BussinessAccount acc5 = acc3 as BussinessAccount; //outra forma de casting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount; //outra forma de casting
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
