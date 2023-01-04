using LinqExercicioFinal.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LinqExercicioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Aulas\Gitlucas\Curso_Csharp\Linq\linqExercicioFinal.csv

            Console.Write("Endereço do arquivo: ");
            string path = Console.ReadLine();

            List<Funcionario> func = new List<Funcionario>();

            Console.Write("Salario a validar: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email das pessoas que recebem mais que o salario acima:");

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] dados = sr.ReadLine().Split(",");
                        double grana = double.Parse(dados[2], CultureInfo.InvariantCulture);
                        Funcionario funcionario = new Funcionario(dados[0], dados[1], grana);
                        func.Add(funcionario);
                    }
                }
                var s = func
                    .Where(x => x.Salario > salario).OrderBy(y => y.Email).Select(z => z.Email);

                foreach(string item in s)
                {
                    Console.WriteLine(item);
                }

                var soma = func.Where(x => x.Nome[0] == 'M').Sum(y => y.Salario);

                Console.WriteLine("Soma dos salarios das pessoas que começam com a letra M: " + soma.ToString("F2", CultureInfo.InvariantCulture));



            }
            catch(Exception e)
            {
                Console.WriteLine("error: " + e);
            }
        }
    }
}
