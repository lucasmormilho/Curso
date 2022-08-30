
namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; } //não pode alterar
        public string Holder { get; private set; } //não pode alterar
        public double Balance { get; protected set; } // pode alterar apenas na classe ou subclasse

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw (double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }

}
