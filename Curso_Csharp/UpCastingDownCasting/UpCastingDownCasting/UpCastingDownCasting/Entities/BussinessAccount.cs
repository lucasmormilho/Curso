using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingDownCasting.Entities
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinessAccount()
        {

        }

        public BussinessAccount(int number, string holder, double balance, double loanlimit)
            : base(number, holder, balance) //chamando o construtor do account
        {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
