﻿using System.Globalization;
using System;
using RentCarNoInterface.Entities;
using RentCarNoInterface.Services;

namespace RentCarNoInterface
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
            DateTime fim  = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro aluguelCarro = new AluguelCarro(inicio, fim, new Veiculo(modelo)); //atento

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora,dia);

            servicoAluguel.ProcessarNotaFiscal(aluguelCarro);

            Console.WriteLine("PAGAMENTO:");
            Console.WriteLine(aluguelCarro.NotaFiscal);

        }
    }
}
