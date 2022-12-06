using System;
using System.Globalization;
using InterfaceExercicioContrato.Entities;
using InterfaceExercicioContrato.Services;

namespace InterfaceExercicioContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato:");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data(dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Numero de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            ServicoContrato servico = new ServicoContrato(new ServicoPagamentoPaypal());

            servico.ProcessarContrato(contrato,parcelas);

            Console.WriteLine("Parcelas: ");
            foreach (Parcelas item in contrato.Parcelas)
            {
                Console.WriteLine(parcelas);
            }
        }
    }
}
