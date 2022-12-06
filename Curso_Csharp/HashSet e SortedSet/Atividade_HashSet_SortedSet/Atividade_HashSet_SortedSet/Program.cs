using System;
using System.Collections.Generic;

namespace Atividade_HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {

            //CONJUNTOS

            //-------------------------------

            //HASH
            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Computer")); 

            //foreach (string item in set)
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------------------

            //SORTED
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //UNION
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //união de c com b...união algebrica...inserir todos elementos de b que não estejam dentro do c.
            PrintCollection(c);

        }

        static void PrintCollection<T>(IEnumerable<T> collection) //SUPER GENERICO !!!
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
