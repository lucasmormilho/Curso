using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior=" + resultado); 
        }

        static int Maior(int a, int b,  int c) //int SERIA A SAIDA
        {
            int m = 0;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else if (c > a && c > b)
            {
                m = c;
            }
            return m;
        }
    }
}
