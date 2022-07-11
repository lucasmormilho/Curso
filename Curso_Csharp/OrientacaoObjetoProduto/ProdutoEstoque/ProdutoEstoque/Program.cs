using ProdutoEstoque.Model;
using System;
using System.Globalization;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Digite o nome do produto");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preco do produto");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade");
            p.Quantidade = int.Parse(Console.ReadLine());

            //double total = p.ValorTotalemEsqtoque(); //SEM SOBRECARGA
            //Console.WriteLine("Produto: " + p.Nome + " , valor : " + p.Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + p.Quantidade + " unidades, " + " Total: " + total.ToString("F2", CultureInfo.InvariantCulture)); //SEM SOBRECARGA

            Console.WriteLine("Dados produto: " + p); //SOBRECARGA

            Console.Write("Adicione mais produtos (qtd): ");
            int add = int.Parse(Console.ReadLine());
            p.AdicionarProduto(add);

            //total = p.ValorTotalemEsqtoque(); //SEM SOBRECARGA
            //Console.WriteLine("Produto atualizado: " + p.Nome + " , valor : " + p.Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + p.Quantidade + " unidades, " + " Total: " + total.ToString("F2", CultureInfo.InvariantCulture)); //SEM SOBRECARGA

            Console.WriteLine("Dados produto atualizado: " + p); //SOBRECARGA

            Console.Write("Retire produtos (qtd): ");
            int Remover = int.Parse(Console.ReadLine());
            p.RemoverProduto (Remover);

            //total = p.ValorTotalemEsqtoque(); //SEM SOBRECARGA
            //Console.WriteLine("Produto atualizado: " + p.Nome + " , valor : " + p.Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + p.Quantidade + " unidades, " + " Total: " + total.ToString("F2", CultureInfo.InvariantCulture)); //SEM SOBRECARGA

            Console.WriteLine("Dados produto atualizado: " + p); //SOBRECARGA

            Console.ReadKey();

        }
    }
}
