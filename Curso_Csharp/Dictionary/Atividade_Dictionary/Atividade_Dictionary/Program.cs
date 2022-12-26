using System;
using System.Collections.Generic;
using System.IO;

namespace Atividade_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

             //melhor que o add
             //dictionary não aceita repetição
            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99711234";
            cookies["phone"] = "99221234"; //o valor vai subscrever

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");
            
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("Não possui a chave email!");
            }

            Console.WriteLine("Tamanho: " + cookies.Count);

            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            //TODOS
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            //TODOS VAR
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            //DESAFIO!!!

            
            string path = @"C:\Aulas\eleicao.txt";
            

            try
            {
                Dictionary<string, int> eleicao = new Dictionary<string, int>();
                using (StreamReader arquivo = File.OpenText(path))
                {
                    while (!arquivo.EndOfStream)
                    {
                        string[] val = arquivo.ReadLine().Split(',');
                        string candidato = val[0];
                        int votos = int.Parse(val[1]);
                        if (eleicao.ContainsKey(candidato))
                        {
                            eleicao[candidato] += votos;
                        }
                        else
                        {
                            eleicao[candidato] = votos;
                        }

                    }

                    foreach(var item in eleicao)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
