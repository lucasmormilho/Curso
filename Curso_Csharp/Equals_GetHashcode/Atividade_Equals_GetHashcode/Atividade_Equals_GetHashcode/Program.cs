using Atividade_Equals_GetHashcode.Entities;
using System;

namespace Atividade_Equals_GetHashcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Maria";

            //Console.WriteLine(a.Equals(b)); //mais lento porem 100%

            //string c = "Maria";
            //string d = "Maria";

            //Console.WriteLine(c.GetHashCode()); //mais rapido porem pode ter erro
            //Console.WriteLine(d.GetHashCode());

            Cliente a = new Cliente {Nome = "Maria", Email = "maria@gmail.com"};
            Cliente b = new Cliente {Nome = "Alex", Email = "maria@gmail.com" };


            Console.WriteLine(a.Equals(b)); //compara o conteudo do equals personalizado
            Console.WriteLine(a == b); //show...compara referencia de memoria
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());



        }
    }
}
