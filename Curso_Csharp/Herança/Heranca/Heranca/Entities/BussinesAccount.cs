
namespace Heranca.Entities
{
    class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinesAccount()
        {

        }

        public BussinesAccount(int number, string holder, double balance, double loanlimit) 
            : base (number,holder,balance) //chamando o construtor do account
        {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
