using System;
using TryCatch.Entities;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero do quarto: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Check-in data (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out data (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("erro, checkOut precisa ser maior que checkIn.");
            }
            else if (checkOut < DateTime.Now || checkIn < DateTime.Now)
            {
                Console.WriteLine("erro, datas devem ser futuras.");
            }
            else
            {
                Reserva reserva = new Reserva(numero, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();

                Console.WriteLine("Entre com os dados para atualizar a reserva:");

                Console.Write("Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());


                string error = reserva.atualizarDatas(checkIn,checkOut);

                if (error != null)
                {
                    Console.WriteLine("error na reserva: " + error);
                }
                else
                {
                    reserva.atualizarDatas(checkIn, checkOut);
                    Console.WriteLine("Reserva: " + reserva);
                }

            }
        }
    }
}

