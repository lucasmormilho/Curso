using Hash_Igualdade.Entities;
using System;
using System.Collections.Generic;

namespace Hash_Igualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "lucas";
            //string b = "lucas";
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            ////IGUALDADE --> POR TRÁS ELE FAZ UM GETHASHCODE E DEPOIS UM EQUALS --> ELES ESTÃO IMPLEMENTADOS POR CONTA DO STRING DO CONJUNTO
            //HashSet<string> set = new HashSet<string>();

            //set.Add("Maria");
            //set.Add("Alex");

            //Console.WriteLine(set.Contains("Maria"));


            //SEM GETHASHCODE E EQUALS -- VAI DAR FALSE
            //CLASSE DO TIPO REFERENCIA SEM GETHASHCODE E EQUALS COMPARA AS REFERENCIAS DE MEMORIA NÃO O CONTEUDO/VALOR
            //HashSet<Product> a = new HashSet<Product>();
            //a.Add(new Product("TV", 900.0));
            //a.Add(new Product("Notebook", 1200.0));

            //HashSet<Point> b = new HashSet<Point>();
            //b.Add(new Point(3, 4));
            //b.Add(new Point(5, 10));
            //Product prod = new Product("Notebook", 1200.0);
            //Console.WriteLine(a.Contains(prod)); //ele não olha o conteudo !!! mesmo sendo os  conteudos iguais. O metodo contains olha para o tipo

            //COM GETHASHCODE E EQUALS -- VAI DAR TRUE
            //ELE COMPARA O CONTEUDO POR CONTA DO GETHASHCODE E EQUALS IMPLEMENTADO NA CLASSE
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));
            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            //NOVO TESTE
            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); //mesmo não implementado o hashcode na classe point ele deu como verdaddeiro

        }
    }
}
