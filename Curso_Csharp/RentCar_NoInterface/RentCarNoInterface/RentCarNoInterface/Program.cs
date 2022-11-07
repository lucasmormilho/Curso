using System.Globalization;
using System;
using RentCarNoInterface.Entities;

namespace RentCarNoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.WriteLine("Modelo do carro:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Data de saida do carro:");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Data de retorno do carro:");
            DateTime fim  = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            AluguelCarro aluguel = new AluguelCarro(inicio, fim, new Veiculo(modelo)); //atento
        

        }
    }
}
