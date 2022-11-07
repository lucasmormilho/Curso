using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerCsv.Entities
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Produtos()
        {

        }

        public Produtos(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public double Soma(double valor, int quantidade)
        {
            return valor * quantidade;
        }
    }
}
