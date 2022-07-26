using System;

namespace VetorExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Digite a quantidade de quartos: ");
            int qtd = int.Parse(Console.ReadLine());
            
            Estudantes[] locacao = new Estudantes[qtd];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());


            for (var i=1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                locacao[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (locacao[i] != null)
                {
                    Console.WriteLine(i + ": " + locacao[i]);
                }
            }


        }
    }
}
