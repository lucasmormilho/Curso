using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) //chamando o construtor do account
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //escrever override e dar enter...espaço...e vai aparecer todos os metodos virtual
        //public override void Withdraw(double amount) //sobreposição com override da classe account metodo withdraw
        //{
        //    Balance -= amount;
        //}

        //uso da palavra BASE no override
        //nesse caso vai descontar 5 reais mais 2 reais 
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
