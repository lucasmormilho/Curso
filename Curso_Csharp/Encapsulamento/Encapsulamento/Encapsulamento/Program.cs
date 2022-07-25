using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("MESA", 500.00, 10);

            //p.Quantidade = 20; // ISSO NÃO É BOM !!!! O PROGRAMADOR MUDAR O VALOR MANUALMENTE

            //ENCAPSULAMENTO GET NOME
            Console.WriteLine(p.GetNome());

            //ENCAPSULAMENTO SET NOME
            p.SetNome(Console.ReadLine()); //MAIS SEGURANÇA CONTROLE DE ACESSO
            Console.WriteLine(p.GetNome());

            //ENCAPSULAMENTO GET PRECO
            Console.WriteLine(p.GetPreco());

            //ENCAPSULAMENTO GET QTD
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
