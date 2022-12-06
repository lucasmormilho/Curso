using System;
using System.Globalization;
using System.Collections.Generic;
using Generics_restricao.Services;
using Generics_restricao.Entities;

namespace Generics_restricao
{
    class Program
    {
        static void Main(string[] args)
        {
            //tratamento int
            //List<int> list = new List<int>();
            //Console.Write("Entre N: ");
            //int n = int.Parse(Console.ReadLine());
            //for(var i = 0; i < n; i++)
            //{
            //    Console.Write("numero " + i + " : ");
            //    int x = int.Parse(Console.ReadLine());
            //    list.Add(x);
            //}
            //ServicoCalculo servicoCauculo = new ServicoCalculo();
            //int max = servicoCauculo.Max(list);
            //Console.Write("Maior: " +  max);

            List<Produtos> list = new List<Produtos>();
            Console.Write("Entre N: ");
            int n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string nome = vect[0];
                double valor = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Produtos(nome, valor));
            }
            ServicoCalculo servicoCauculo = new ServicoCalculo();
            Produtos max = servicoCauculo.Max(list); //precisa do icomparable na classe produto
            Console.Write("Maior: " + max);


        }
    }
}
