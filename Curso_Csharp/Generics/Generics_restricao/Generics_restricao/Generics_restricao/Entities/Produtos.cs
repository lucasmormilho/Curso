using System.Globalization;
using System;

namespace Generics_restricao.Entities
{
    class Produtos : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produtos))
            {
                throw new ArgumentException("comparible erro: argumento não é um produto");
            }
            
            Produtos outro = obj as Produtos;

            return Preco.CompareTo(outro.Preco); //COMPARAÇÃO
        }
    }
}
