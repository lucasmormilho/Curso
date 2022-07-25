using System;
using System.Globalization;

namespace MembrosEstaticosExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago : $" + CalcDolar.ConversorDeMoeda(cotacao,qtd).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
