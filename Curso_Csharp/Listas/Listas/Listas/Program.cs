using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTA INSTANCIADA COM ELEMENTOS
            List<string> nomes = new List<string> { "Maria", "Alex", "Bob" };
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------");

            //LISTA INSTANCIADA VAZIA
            List<string> nomes2 = new List<string>();
            nomes2.Add("Maria");
            nomes2.Add("Alex");
            nomes2.Add("Bob");
            nomes2.Add("Anna");
            nomes2.Add("Lucas");
            nomes2.Add("Yuri");
            nomes2.Add("Carlos");
            nomes2.Add("Eduardo");

            nomes2.Insert(2, "Marcos");

            Console.WriteLine("------------------------------------------");

            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Count da lista: " + nomes2.Count);

            Console.WriteLine("------------------------------------------");

            string s1 = nomes2.Find(Test); //LAMBDA PREDICADO DE FORMA QUE FUNCIONA
            Console.WriteLine("First A:" + s1);
            static bool Test (string s)
            {
                return s[0] == 'A';
            }

            Console.WriteLine("------------------------------------------");

            string s2 = nomes2.Find(x => x[0] == 'A'); //LAMBDA PREDICADO DE FORMA SIMPLES
            Console.WriteLine("First A:" + s2);

            Console.WriteLine("------------------------------------------");

            string s3 = nomes2.FindLast(x => x[0] == 'A'); //LAMBDA PREDICADO DE FORMA SIMPLES
            Console.WriteLine("Last A:" + s3);

            Console.WriteLine("------------------------------------------");

            int pos1 = nomes2.FindIndex(x => x[0] == 'A'); //LAMBDA PREDICADO DE FORMA SIMPLES
            Console.WriteLine("First Position A: " + pos1);

            Console.WriteLine("------------------------------------------");

            int pos2 = nomes2.FindLastIndex(x => x[0] == 'A'); //LAMBDA PREDICADO DE FORMA SIMPLES
            Console.WriteLine("First Position A: " + pos2);

            Console.WriteLine("------------------------------------------");

            List<string> listaFiltro = nomes2.FindAll(x => x.Length >= 6);
            foreach(string obj in listaFiltro)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------");

            nomes2.Remove("Alex");
            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------");

            nomes2.RemoveAll(x => x[2] == 'b');
            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------");

            nomes2.RemoveAt(3); //posição
            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("------------------------------------------");

            nomes2.RemoveRange(0,2); //inicio e faixa
            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
