using AulaComparison.Entities;
using System;
using System.Collections.Generic;

namespace AulaComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Notebook", 1200.00));
            lista.Add(new Produto("Tablet", 450.00));

            //COM ICOMPARABLE --> PROBLEMA QUE SE FOR COMPARA O PREÇO PRECISA MUDAR A CLASSE E ISSO NÃO É BOM
            //lista.Sort(); 

            //COMPARISON LOCAL --> COM FUNÇÃO --> REFERENCIA PARA FUNÇÃO --> DELEGATE --> COM TYPE SAFETY
            //lista.Sort(CompararProdutos);

            //COMPARISON DECLARANDO --> TENDO UMA VARIVEL QUE GUARDA UMA REFERENCIA PARA UMA FUNÇÃO
            //PASSANDO UM ARGUMENTO PARA FUNÇAO SORT
            //Comparison<Produto> comp = CompararProdutos;
            //lista.Sort(comp);

            //EXPRESSÃO LAMBDA  --> ANONIMA NA VARIAVEL
            //Comparison<Produto> comp = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
            //lista.Sort(comp);

            //EXPRESSÃO LAMBDA  --> DIRETAMENTE NA FUNÇÃO SORT
            lista.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));


            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }
        }

        //FUNÇÃO PARA COMPARAR
        static int CompararProdutos(Produto p1, Produto p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
    }
}
