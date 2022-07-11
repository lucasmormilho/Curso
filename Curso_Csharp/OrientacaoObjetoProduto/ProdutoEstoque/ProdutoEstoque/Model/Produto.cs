using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProdutoEstoque.Model
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalemEsqtoque()
        {
            return Preco * Quantidade;
        }

        public void  AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //sobrecarga
        public override string ToString()
        {
            return Nome 
                + " , valor : " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + " , " + Quantidade 
                + " unidades, " 
                + " Total: " 
                + ValorTotalemEsqtoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
