using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------------------------------
            //VETOR SIMPLES

            //Console.Write("Quantidade do vetor: ");
            //int n = int.Parse(Console.ReadLine());

            //double[] vector = new double[n];

            //for(var x = 0; x < n; x++)
            //{
            //    Console.Write("Valor do vetor" + x + ":");
            //    vector[x] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double soma = 0.0;
            //for (int i = 0;  i < n; i++)
            //{
            //    soma += vector[i];
            //}

            //Console.WriteLine("Soma dos vetores: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            //double media = soma / n;

            //Console.WriteLine("Média dos vetores: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //------------------------------------------------------------------------------------------------------
            //VETOR COM OBJETO


            Console.WriteLine("Digite a quantidade produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i = 0; i < vect.Length; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto 
                { 
                    Name = name, 
                    Price = price 
                };

            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;

            Console.WriteLine("Preço médio de: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
