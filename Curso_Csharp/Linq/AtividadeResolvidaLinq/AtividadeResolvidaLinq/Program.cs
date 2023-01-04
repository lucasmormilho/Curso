using AtividadeResolvidaLinq.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;

namespace AtividadeResolvidaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Aulas\Gitlucas\Curso_Csharp\linqArquivo.csv";
            List<Produto> prod = new List<Produto>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] separar = sr.ReadLine().Split(",");
                        string nome = separar[0];
                        double preco = double.Parse(separar[1], CultureInfo.InvariantCulture);
                        prod.Add(new Produto(nome, preco));
                    }
                }

                foreach(Produto item in prod)
                {
                    Console.WriteLine(item.Nome + " - " + item.Preco);
                }

                Console.WriteLine();
                var x = prod.Where(x => x.Preco >= 0.0).Average(a => a.Preco);
                Console.WriteLine("Média total: "  + x.ToString("F2"));

                Console.WriteLine();
                Console.WriteLine("Produtos com preço abaixo da média:");
                var y = prod.Where(a => a.Preco < x).OrderByDescending(x => x.Nome).Select(p => p.Nome);
                foreach (string item in y)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("erro: " + e);
            }

            

        }
    }
}
