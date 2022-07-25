using System;
using System.Globalization;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            //CONSTRUTORES
            Produto p = new Produto(nome, preco, qtd); //3 ARGUMENTOS

            Produto X = new Produto(nome, preco); //2 ARGUMENTOS

            Produto y = new Produto(); //SEM ARGUMENTOS

            //SINTAXE ALTERNATIVA
            Produto sintaxe_alternativa = new Produto { Nome = "Mesa", Preco = 500.0, Quantidade = 20 };


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
