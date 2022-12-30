using AtividadeFunc.Entities;
using System;
using System.Collections.Generic;
using System.Linq; //PARA USAR O SELECT

namespace AtividadeFunc
{
    class Program
    {
        //action retorna void e func retorna um valor

        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD", 80.90));

            ////Versao 1 com metodo e select
            ////o select recebe um func
            ////precisa converter para lista Tolist
            //List<string> resultado = lista.Select(Maiuscula).ToList();

            ////Versão 2 com func e select
            ////Criar um delegate que recebe um produto e retorna uma string
            //Func<Produto, string> func = Maiuscula;
            //List<string> resultado = lista.Select(func).ToList();

            ////Versão 3 com lambda
            //Func<Produto, string> func = p => p.Nome.ToUpper();
            //Func<Produto, string> func2 = p => { return p.Nome.ToUpper(); }; //com chaves a expressaão lambda precisa de um return pois retorna um string
            //List<string> resultado = lista.Select(func).ToList();

            ////Versão 4 com lambda inline
            List<string> resultado = lista.Select(p => p.Nome.ToUpper()).ToList();

            foreach (string s in resultado)
            {
                Console.WriteLine(s);
            }

        }

        static string Maiuscula(Produto p)
        {
            return p.Nome.ToUpper();
        }
    }
}
