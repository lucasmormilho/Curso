using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinesAccount account = new BussinesAccount(8010, "Lucas", 100.0, 500.0);
            Console.WriteLine(account.Balance);

        }
    }
}
