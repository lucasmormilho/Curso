using System;

namespace VetorExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de quartos: ");
            int qtd = int.Parse(Console.ReadLine());

            string[] quartos = new string[qtd];

            for(var i=0; i < qtd; i++)
            {
                Console.WriteLine("Quartos: " + i); 
            }
            
            Console.Write("Digite a quantidade de estudantes: ");
            int n = int.Parse(Console.ReadLine());
            
            Estudantes[] locacao = new Estudantes[n];

            for (var i = 0; i < n; i++)
            {
                Console.Write("Digite o numero do quarto do estudante numero (" + i + "), de zero a " + (qtd - 1) + ": ");
                int locar = int.Parse(Console.ReadLine());

                Console.WriteLine("digite o nome do estudante: ");
                string name = Console.ReadLine();
                Console.WriteLine("digite o email do estudante: ");
                string email = Console.ReadLine();

                locacao[n] = new Estudantes { Name = name, Email = email };

                quartos[locar] = "alugado";

            }

            Console.WriteLine("Atualização dos quartos: ");
            
            for (var i = 0; i < qtd; i++)
            {
                Console.WriteLine("Quartos: " + quartos);
            }


            int sobra = qtd - n;
            Console.WriteLine("Sobra " + sobra + " quartos.");

        }
    }
}
