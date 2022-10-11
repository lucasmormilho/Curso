using MetodoAbastratoExercicio.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace MetodoAbastratoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>();

            Console.Write("Entre com numero de pagadores :");
            int pagadores = int.Parse(Console.ReadLine());

            for(int i = 1; i <= pagadores; i++)
            {
                Console.WriteLine($"Pagador #{i} : ");
                Console.Write("Pessoa fisica ou juridica (f/j)");
                char tipo = char.Parse(Console.ReadLine());
                if(tipo == 'f')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Gasto com saude: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, rendaAnual, gastoSaude));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantidade de funcionarios: ");
                    int nFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, rendaAnual, nFuncionarios));
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TOTAL DE IMPOSTO PAGO");
            double total = 0.0;
            foreach(Contribuintes item in list)
            {
                Console.WriteLine(item.Nome + ": $ " + item.Imposto().ToString("F2",CultureInfo.InvariantCulture));
                total += item.Imposto();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("SOMA DE IMPOSTO: $ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
