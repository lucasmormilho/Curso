using System;
using System.Collections.Generic;
using System.Linq;
using AtividadeLinq.Entities;

namespace AtividadeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            ////INTRODUÇÃO
            //ESPECIFICAR O DATA SOURCE
            int[] numeros = new int[] { 2, 3, 4, 5 };

            //DEFINIR A CONSULTA - query
            var pares = numeros
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            IEnumerable<int> impares = numeros //ienumerable aceita pois é mais generico
                .Where(p => p % 2 != 0)
                .Select(i => i * 10);

            //EXECUTAR A CONSULTA
            foreach (int x in pares)
            {
                Console.WriteLine("par: " + x);
            }
            foreach (int x in impares)
            {
                Console.WriteLine("impar: " + x);
            }
            //---------------------------------------------------------------

            ////OPERAÇÕES LINQ
            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramenta", Tier = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Tier = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletronicos", Tier = 1 };

            List<Produto> prod = new List<Produto>()
            {
                new Produto() { Id = 1, Nome = "Computador", Preco = 1100.0, Categoria = c2 },
                new Produto() { Id = 2, Nome = "Martelo", Preco = 90.0, Categoria = c1 },
                new Produto() { Id = 3, Nome = "TV", Preco = 1700.0, Categoria = c3 },
                new Produto() { Id = 4, Nome = "Notebook", Preco = 1300.0, Categoria = c2 },
                new Produto() { Id = 5, Nome = "Alicate", Preco = 80.0, Categoria = c1 },
                new Produto() { Id = 6, Nome = "Tablet", Preco = 1100.0, Categoria = c2 },
                new Produto() { Id = 7, Nome = "Camera", Preco = 700.0, Categoria = c3 },
                new Produto() { Id = 8, Nome = "Impressora", Preco = 350.0, Categoria = c3 },
                new Produto() { Id = 9, Nome = "Macbook", Preco = 1800.0, Categoria = c2 },
                new Produto() { Id = 10, Nome = "Som", Preco = 700.0, Categoria = c3 },
                new Produto() { Id = 11, Nome = "Prego", Preco = 70.0, Categoria = c1 }
            };

            var r1 = prod
                .Where(cat1 => cat1.Categoria.Tier == 1 && cat1.Preco < 900.0);
            print("Mostrar categoria 1 e preço menor que 900:", r1);

            var r2 = prod
                .Where(tools => tools.Categoria.Nome == "Ferramenta")
                .Select(prod => prod.Nome);
            print("Mostrar apenas produtos de ferramentas",r2 );

            var r3 = prod
                .Where(prod => prod.Nome[0] == 'C')
                .Select(x => new { x.Nome, x.Preco, categoriaNome = x.Categoria.Nome }); //USANDO LAMBDA E ALIAS PARA RENOMEAR CAMPO
            print("Produtos que começam com C e objeto anonimo", r3);

            var r4 = prod
                .Where(rato => rato.Categoria.Tier == 1)
                .OrderBy(gato => gato.Preco)
                .ThenBy(vaca => vaca.Nome);
            print("CAtegoria 1 e ordenado por preço e depois nome", r4);

            var r5 = r4.Skip(2).Take(4);
            print("Pula dois elementos e pega 4 do linq anterior", r5);

            var r6 = prod.First();
            Console.WriteLine("primeiro elemento FIRST: " + r6);

            //var r7 = prod.Where(f => f.Preco > 3000.0).First(); // vai gerar uma exceção caso a lista esteja vazia
            var r7 = prod.Where(f => f.Preco > 3000.0).FirstOrDefault(); // usar esse
            Console.WriteLine("Maior que 3k first ou primeiro elemento: " + r7);

            var r8 = prod.Where(y => y.Id == 3).SingleOrDefault(); //caso tire o singleordefault ele se tornara uma coleção ienumerable
            Console.WriteLine("Busca por ID singleordefault: " + r8);

            var r9 = prod.Where(x => x.Id > 100).SingleOrDefault();
            Console.WriteLine("Busca maior que 100 id:" + r9);

            //AGREGAÇÃO

            var r10 = prod.Max(e => e.Preco); //precisa de uma linq o max
            Console.WriteLine("MAX preço: " + r10);

            var r11 = prod.Min(m => m.Preco);
            Console.WriteLine("Minimo preço: " + r11);

            var r12 = prod
                .Where(f => f.Categoria.Id == 1)
                .Sum(p => p.Preco);
            Console.WriteLine("soma das categoria 1: " + r12);

            var r13 = prod
                .Where(f => f.Categoria.Id == 1)
                .Average(p => p.Preco);
            Console.WriteLine("media das categoria 1: " + r13);

            var r14 = prod
                .Where(f => f.Categoria.Id == 5)
                .Select(s => s.Preco)
                .DefaultIfEmpty(0.0) //se for false ele coloca o valor zero se não colocar vai dar exception
                .Average();
            Console.WriteLine("media das categoria 5: " + r14);

            //map reduce -- agregação personalizada
            var r15 = prod
                .Where(f => f.Categoria.Id == 5)
                .Select(p => p.Preco)
                .Aggregate(0.0, (x, y) => x + y); //montar a propria soma e para não dar erro se coloca o 0,0
            Console.WriteLine("categoria 1 com agregatte e soma: " + r15);


            //GROUP BY
            var r16 = prod
                .GroupBy(g => g.Categoria);

            foreach(IGrouping<Categoria, Produto> item in r16)
            {
                Console.WriteLine();
                Console.WriteLine("categoria " + item.Key.Nome + " :");
                foreach (Produto p in item)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine(" ");
            }

            //NOTAÇÃO SQL
            Console.WriteLine();
            Console.WriteLine("NOTAÇÃO SQL");
            
            
            var r17 = from x in prod
                      where x.Categoria.Tier == 1 && x.Preco < 900.0
                      select x;
            print("Mostrar categoria 1 e preço menor que 900:", r17);

            var r18 = from a in prod
                      where a.Categoria.Nome == "Ferramenta"
                      select a.Nome;
            print("Mostrar apenas produtos de ferramentas", r18);


            var r19 = from x in prod
                      where x.Nome[0] == 'C'
                      select new { x.Nome, x.Preco, CategoriaNome = x.Categoria.Nome };
            print("Produtos que começam com C e objeto anonimo", r19);

            var r20 = from y in prod
                      where y.Categoria.Tier == 1
                      orderby y.Nome
                      orderby y.Preco
                      select y;
            print("Categoria 1 e ordenado por preço e depois nome", r20);


            var r21 = (from p in r20
                       select p)
                       .Skip(2) //fazer expressao em parenteses
                       .Take(4);
            print("Pula dois elementos e pega 4 do linq anterior", r21);


            var r22 = from x in prod
                      group x by x.Categoria;

            foreach (IGrouping<Categoria, Produto> item in r16)
            {
                Console.WriteLine();
                Console.WriteLine("categoria sql " + item.Key.Nome + " :");
                foreach (Produto p in item)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine(" ");
            }

        }



        //função auxiliar para imprimir na tela
        static void print<T>(string mensagem, IEnumerable<T> colecao)
        {
            Console.WriteLine(" ");
            Console.WriteLine(mensagem);
            foreach (T x in colecao)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(" ");
        }

    }
}
