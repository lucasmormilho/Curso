using System;
using System.IO;
using System.Collections.Generic;

namespace Usando_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Aulas\Gitlucas\Curso_Csharp\Directory\PastaTestes";

            //-------------------MOSTRAR PASTAS
            //try
            //{
            //    //ienumerable é uma lista mais generica.
            //    IEnumerable<string> folder =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    //var folder =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

            //    Console.WriteLine("Pastas: ");
            //    foreach (string s in folder)
            //    {
            //        Console.WriteLine(s);
            //    }

            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("Erro: " + e.Message);
            //}


            //-------------------MOSTRAR ARQUIVOS
            //try
            //{
            //    //ienumerable é uma lista mais generica.
            //    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    //var files =  Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

            //    Console.WriteLine("Arquivos: ");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Erro: " + e.Message);
            //}


            //-------------------CRIAR PASTAS
            try
            {
                //ienumerable é uma lista mais generica.
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                //var files =  Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Arquivos: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\PastaCriada");

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
