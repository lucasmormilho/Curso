using System;
using TryCatch3.Entities;
using TryCatch3.Entities.Exceptions;

namespace TryCatch3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do quarto: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Check-in data (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numero, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva:");
                Console.Write("Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reserva.atualizarDatas(checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);
            }
            catch (DomainException e) //especifico de datas
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch(FormatException e) //especifico do formato
            {
                Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch(Exception e) //generico
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }

        }
    }
}

