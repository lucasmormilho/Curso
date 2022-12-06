using RentCarComInterface.Entities;
using RentCarComInterface.Services;
using System;
using System.Globalization;

namespace RentCarComInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.Write("Modelo do carro:");
            string modelo = Console.ReadLine();
            Console.Write("Data de saida do carro:");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de retorno do carro:");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro aluguel = new AluguelCarro(inicio, fim, new Veiculo(modelo)); //instancia do aluguel

            ServicoAluguel servico = new ServicoAluguel(hora, dia, new TaxaArgentina()); //instancia da interface determinando o tipo de taxa (brasil, portugal, EUA, etc)

            servico.ProcessarPagamento(aluguel);

            Console.WriteLine("PAGAMENTO: ");
            Console.WriteLine(aluguel.Fatura);
        }
    }
}
