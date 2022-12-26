using System;
using System.Collections.Generic;
using Hash_Conjunto_atividade2.Entities;

namespace Hash_Conjunto_atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<CodAluno> conjunto = new HashSet<CodAluno>();
            //int QtdCurso = 3;
            //for (var x = 0; x < QtdCurso; x++)
            //{
            //    Console.Write("Quantidade alunos do curso " + x + " ?");
            //    int list = int.Parse(Console.ReadLine());
            //    for (var y = 0; y < list; y++)
            //    {
            //        int conj = int.Parse(Console.ReadLine());
            //        conjunto.Add(new CodAluno { Cod = conj });
            //    }
            //}
            //Console.WriteLine("Total de estudantes: " + conjunto.Count);

            //-------------------------------------

            //SEGUNDA SOLUÇÃO

            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
