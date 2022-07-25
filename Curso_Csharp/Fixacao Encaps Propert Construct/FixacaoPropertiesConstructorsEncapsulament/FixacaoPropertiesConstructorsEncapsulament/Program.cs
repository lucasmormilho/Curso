using System;
using System.Globalization;

namespace FixacaoPropertiesConstructorsEncapsulament
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;

            Console.Write("Entre com o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Deposito inicial? (s=sim e n=não): ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre com o valor: $");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numeroConta, nomeTitular, deposito);
                Console.WriteLine(x);

            }
            else
            {
                x = new Conta(numeroConta, nomeTitular);
                Console.WriteLine(x);
            }
            Console.Write("Entre com o valor para deposito: $");
            x.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(x);

            Console.Write("Entre com o valor para saque: $");
            x.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(x);
        }
    }
}
