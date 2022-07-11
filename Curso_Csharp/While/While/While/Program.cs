using System;
using System.Globalization;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            int senha = 1234;
            Console.WriteLine("Digite a senha:");
            int recebe = int.Parse(Console.ReadLine());
            while (senha != recebe)
            {
                Console.WriteLine("Senha invalida");
                Console.WriteLine("Digite a senha:");
                recebe = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

            //Console.WriteLine("Digite um número inicial:");
            //double raiz = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (raiz >= 0.0)
            //{
            //    double mostrar = raizquadrada(raiz);
            //    Console.WriteLine(mostrar.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro número:");
            //    raiz = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //Console.WriteLine("Numero Negativo");
        }

        //public static double raizquadrada(double n1)
        //{
        //    double resultado = Math.Sqrt(n1);
        //    return resultado;
        //}

    }
}
