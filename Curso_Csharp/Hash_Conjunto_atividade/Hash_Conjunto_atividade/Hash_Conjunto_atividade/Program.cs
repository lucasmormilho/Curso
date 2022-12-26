using System;
using System.Collections.Generic;
using System.IO;
using Hash_Conjunto_atividade.Entities;

namespace Hash_Conjunto_atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a coleção: ");
            Console.WriteLine(" ");
            string path = @"C:\Aulas\hash.txt";

            //instanciar o conjunto
            //usar o hashset pois é mais rapido e não importa a ordem
            HashSet<RegistroLog> conjunto = new HashSet<RegistroLog>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] linha = sr.ReadLine().Split(' '); //lendo linha e recortando pelo espaço em branco
                        string name = linha[0];
                        DateTime dataHora = DateTime.Parse(linha[1]);
                        conjunto.Add(new RegistroLog {Username = name, DataHora = dataHora }); //sem construtor // usuario repetido não vai entrar no conjunto porque implantamos o hashcode e equals
                        Console.WriteLine(name + " " + dataHora);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Total de usuarios: " + conjunto.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e);
            }
        }
    }
}
