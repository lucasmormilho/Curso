using AtividadePredicate.Entities;
using System;
using System.Collections.Generic;

namespace AtividadePredicate
{
    class Program
    {


        static void Main(string[] args)
        {

            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD", 80.90));

            ////opção 1 de sintaxe, o removeall precisa receber um predicate
            //lista.RemoveAll(p => p.Preco >= 100.0); //função lambda
            //foreach(Produto item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            ////opção 2 de sintaxe, o removeall precisa receber um predicate
            lista.RemoveAll(TesteProduto); //função lambda
            foreach (Produto item in lista)
            {
                Console.WriteLine(item);
            }

        }

        public static bool TesteProduto(Produto p)
        {
            return p.Preco >= 100.0;
        }
    }
}
