using System;
using System.Collections.Generic;
using System.IO;
using Comparador_IComparable.Entities;

namespace Comparador_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Aulas\Comparable.txt";
            List<Funcionario> list = new List<Funcionario>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();
                   foreach(Funcionario item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
        }
    }
}
