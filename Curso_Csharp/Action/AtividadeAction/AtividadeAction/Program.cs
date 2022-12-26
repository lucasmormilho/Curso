using AtividadeAction.Entities;
using System;
using System.Collections.Generic;

namespace AtividadeAction
{
    class Program
    {
        //PROGRAMA PARA AUMENTAR EM 10% CADA PRODUTO
        //PODERIA USAR UM FOREACH PARA AUMENTAR OS PRODUTOS


        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD", 80.90));

            ////OPÇAO 1 - FOREACH PRECISA DE UM ACTION VOID
            //lista.ForEach(AtualizarPreco);

            ////OPCAO 2 - CRIAR UM OBJETO DO TIPO DELEGATE ACTION
            //Action<Produto> act = AtualizarPreco;
            //lista.ForEach(act);

            ////OPCAO 3 - USAR LAMBDA VOID
            //Action<Produto> act = p => { p.Preco += p.Preco * 0.1; };
            //lista.ForEach(act);

            ////OPCAO 4 - USAR LAMBDA DIRETO NO FOREACH
            lista.ForEach(p => { p.Preco += p.Preco * 0.1; });

            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }
        }

        //função simples para atualizar 1 produto
        static void AtualizarPreco(Produto p)
        {
            p.Preco += p.Preco * 0.1;
        }
    }
}
