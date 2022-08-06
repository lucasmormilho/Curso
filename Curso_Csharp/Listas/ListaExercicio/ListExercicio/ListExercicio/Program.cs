using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            List<funcionarios> Func = new List<funcionarios>();

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario: #" + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("-------------------");

                funcionarios Funcionario = new funcionarios(id, nome, salario);
                Func.Add(Funcionario);
            }

            foreach (funcionarios obj in Func)
            {
                Console.WriteLine(obj.Id);
                Console.WriteLine(obj.Nome);
                Console.WriteLine(obj.Salario);
                Console.WriteLine("---------------------");
            }

            Console.Write("Entre com o id para aumento de salario: ");
            int aumento = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionarios valida = Func.Find(x => x.Id == aumento);

            if (valida != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios correcao = Func.Find(x => x.Id == aumento);
                correcao.Salario += correcao.Salario * porcentagem / 100;

                Console.WriteLine("Lista atualizada");
                foreach (funcionarios obj in Func)
                {
                    Console.WriteLine(obj.Id);
                    Console.WriteLine(obj.Nome);
                    Console.WriteLine(obj.Salario);
                    Console.WriteLine("---------------------");
                }
            }
            else
            {
                Console.WriteLine("id não existe !!!");
            }




        }
    }
}
