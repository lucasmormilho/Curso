using System;
using TryCatch_ExercicioProposto.Entities.Exceptions;
using TryCatch_ExercicioProposto.Entities;
using System.Globalization;

namespace TryCatch_ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com dados da conta:");
                Console.Write("Numero: ");
                int nConta = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Deposito inicial: ");
                double dInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double lSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Valor do saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta conta = new Conta(nConta, nome, dInicial, lSaque);
                conta.Deposito(dInicial);
                conta.Saque(saque);
                Console.WriteLine(conta);

            }
            catch (DomainException e)
            {
                Console.WriteLine("erro:" + e.Message);
            }
        }
    }
}
