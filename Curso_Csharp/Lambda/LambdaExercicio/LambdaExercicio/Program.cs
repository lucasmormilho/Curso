using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var LivrosBiblioteca = new List<Livros>();

            LivrosBiblioteca.Add(new Livros { Nome = "Livro1", Emprestado = false });
            LivrosBiblioteca.Add(new Livros { Nome = "Livro2", Emprestado = true });
            LivrosBiblioteca.Add(new Livros { Nome = "Livro3", Emprestado = false });
            LivrosBiblioteca.Add(new Livros { Nome = "Livro4", Emprestado = true });

            Console.WriteLine("Livros");
            ImprimeLista(LivrosBiblioteca);

            Console.WriteLine("---------------------------------");

            //var LivrosEmprestados = LivrosBiblioteca.Where(EstaEmprestado); //LINQ
            var LivrosEmprestados = LivrosBiblioteca.Where((l) => l.Emprestado); //LAMBDA
            var LivrosDisponiveis = LivrosBiblioteca.Where((l) => l.Emprestado != true); //LAMBDA
            Console.WriteLine("Livros Emprestados");
            ImprimeLista(LivrosEmprestados);
            Console.WriteLine("Livros Disponiveis");
            ImprimeLista(LivrosDisponiveis);


            //bool EstaEmprestado(Livros livro) //na função precisa especificar que é um livro
            //{
            //    return livro.Emprestado;
            //}

            void ImprimeLista(IEnumerable<Livros> livros)
            {
                foreach (var item in livros)
                {
                    Console.WriteLine($"Livro: {item.Nome}");
                }
            }

        }

        public class Livros
        {
            public string Nome { get; set; }
            public bool Emprestado { get; set; }
        }
    }
}
