using System;
using Generics_Atividade.Services;

namespace Generics_Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printservice = new PrintService<int>();

            Console.Write("Quantos valores você vai inserir?");

            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string x = Console.ReadLine();
            //    printservice.addValue(x);
            //}

            //int a = (int)printservice.First();//usando object precisa converter o object para int porem se usar string não aponta erro (type safety) --> NÃO É LEGAL
            //int b = a + 2;
            //Console.WriteLine(b);

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printservice.addValue(x);
            }

            printservice.Print();
            Console.WriteLine("First: " + printservice.First());

        }
    }
}
