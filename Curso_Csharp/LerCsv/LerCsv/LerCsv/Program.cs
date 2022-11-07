using System;
using LerCsv.Entities;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace LerCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Aulas\Gitlucas\Curso_Csharp\LerCsv\DadosOriginais.csv";
            string targePath = @"C:\Aulas\Gitlucas\Curso_Csharp\LerCsv\DadosModificados.csv";
            Produtos p = new Produtos();
            string[] produtos = { };
            List<string> ArquivoFinal =  new List<string>();

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        produtos = line.Split(",");
                        p.Nome = produtos[0];
                        p.Valor = double.Parse(produtos[1], CultureInfo.InvariantCulture);
                        p.Quantidade = int.Parse(produtos[2]);
                        double soma = p.Soma(p.Valor, p.Quantidade);
                        ArquivoFinal.Add(p.Nome + ", " + soma.ToString("F2", CultureInfo.InvariantCulture));

                    }

                    using (StreamWriter sw = File.AppendText(targePath))
                    {
                        foreach (string item in ArquivoFinal)
                        {
                            sw.WriteLine(item.ToUpper());
                        }
                    }
                }
                Console.WriteLine("Dados importados com sucesso!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
