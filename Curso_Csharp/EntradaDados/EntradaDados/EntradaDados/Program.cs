using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //string frase = Console.ReadLine();

            //Console.WriteLine("Você digitou: " + frase);

            //string a = Console.ReadLine();
            //string[] vet = a.Split(" ");

            //Console.WriteLine(vet[0]);
            //Console.WriteLine(vet[1]);
            //Console.WriteLine(vet[2]);

            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Voce digitou: " + n1);

            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine("Voce digitou: " + ch);

            //double n2 = double.Parse(Console.ReadLine());
            //double n3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.WriteLine("Você digitou: " + n2); //em portuga precisa ser virgula ou globalization
            //Console.WriteLine("Você digitou: " + n3); //em portuga precisa ser virgula ou globalization

            //string[] vet2 = Console.ReadLine().Split(' ');
            //string nome = vet2[0];
            //char sexo = char.Parse(vet2[1]);
            //int idade = int.Parse(vet2[2]);
            //double altura = double.Parse(vet2[3],CultureInfo.InvariantCulture);
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);

            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o seu ultimo nome, idade e altura na mesma linha ");
            string[] variados = Console.ReadLine().Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(variados[0]);
            Console.WriteLine(variados[1]);
            Console.WriteLine(variados[2]);






        }
    }
}
