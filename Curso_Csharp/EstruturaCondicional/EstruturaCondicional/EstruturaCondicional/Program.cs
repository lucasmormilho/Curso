using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Bom dia");
            if (x < 15)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Entre com um numero inteiro");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0) //-----OPERADOR MODE --- RESTO DA DIVISÃO
            {
                Console.WriteLine("Numero Par");
            }
            else
            {
                Console.WriteLine("Numero Impar");
            }
            
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Qual hora agora ?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
