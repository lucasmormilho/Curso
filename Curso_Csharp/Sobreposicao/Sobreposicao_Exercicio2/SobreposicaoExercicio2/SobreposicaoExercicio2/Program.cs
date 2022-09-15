using System;
using System.Collections.Generic;
using System.Globalization;

namespace SobreposicaoExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Quantidade de produto:");
            int qtd = int.Parse(Console.ReadLine());

            for (var i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Produto #" + i + ":");
                Console.Write("Tipo: (c/u/i)");
                string tipo = Console.ReadLine();
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Preço:");
                double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == "i")
                {
                    Console.Write("Taxa:");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(taxa, nome, preço));
                }
                else if (tipo == "u")
                {
                    Console.Write("Fabricação (dd/mm/aaaa):");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(data,nome,preço));
                }
                else
                {
                    lista.Add(new Produto(nome, preço));
                }
            }

            Console.WriteLine("PREÇOS:");
            foreach (Produto item in lista)
            {
                Console.WriteLine(item.tagPreço());
            }
        }
    }
}
