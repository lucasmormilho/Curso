using System;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("MESA", 500.00, 10);

            //p.Quantidade = 20; // ISSO NÃO É BOM !!!! O PROGRAMADOR MUDAR O VALOR MANUALMENTE

            //ENCAPSULAMENTO GET NOME
            Console.WriteLine(p.Nome);
            //ENCAPSULAMENTO GET PREÇO
            Console.WriteLine(p.Preco);
            //ENCAPSULAMENTO GET QUANTIDADE
            Console.WriteLine(p.Quantidade);

            //ENCAPSULAMENTO SET NOME
            p.Nome = "TV";
            Console.WriteLine(p.Nome);
        }
    }
}
