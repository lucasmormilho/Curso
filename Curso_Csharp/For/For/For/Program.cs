using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Quantos numeros vc vai somar?");
            //int total = int.Parse(Console.ReadLine());

            //int soma = 0;

            //for (int x = 1; x <= total; x++)
            //{
            //    Console.Write("Valor" + x + ": ");
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}
            //Console.WriteLine("Valor total: " + soma);


            Console.WriteLine("Coloque um valor");

            int n1 = int.Parse(Console.ReadLine());

            for (var x= 0; x <= n1; x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
