using System.Globalization;

namespace FixacaoPropertiesConstructorsEncapsulament
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double ValorConta { get; private set; }

        //CONSTRUTOR
        public Conta(int nconta, string nome)
        {
            NumeroConta = nconta;
            Nome = nome;
        }

        //CONSTRUTOR
        public Conta(int nconta, string nome, double depositoinicial) : this(nconta, nome)
        {
            Deposito(depositoinicial);
        }

        //METODOS
        public void Deposito(double deposito)
        {
            ValorConta += deposito;
        }

        //METODOS
        public void Saque(double saque)
        {
            double imposto = 5.00;
            double Saque = saque + imposto;
            ValorConta = ValorConta - Saque;
        }

        //METODOS
        public override string ToString()
        {
            return "Conta " 
                + NumeroConta 
                + ", Titular: " 
                + Nome + ", Saldo: $" 
                + ValorConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
