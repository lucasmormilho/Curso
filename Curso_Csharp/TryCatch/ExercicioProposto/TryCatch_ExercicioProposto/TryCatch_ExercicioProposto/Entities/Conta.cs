using System.Globalization;
using TryCatch_ExercicioProposto.Entities.Exceptions;


namespace TryCatch_ExercicioProposto.Entities
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double SaqueLimite { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string nome, double saldo, double saqueLimite)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            SaqueLimite = saqueLimite;
        }

        public void Deposito(double valor)
        {
            Saldo = valor;
        }

        public void Saque(double valor)
        {
            if(valor > Saldo)
            {
                throw new DomainException("Saldo insuficiente");
            }
            if (valor > SaqueLimite)
            {
                throw new DomainException("Ultrapassou o limite diario de " + SaqueLimite.ToString("F2", CultureInfo.InvariantCulture));
            }

            Saldo -= valor;
        }

        public override string ToString()
        {
            return "Novo valor: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
