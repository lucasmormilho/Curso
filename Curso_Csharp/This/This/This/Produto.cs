using System.Globalization;


namespace This
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //-----------------------------INICIO SOBRECARGA

        //CONSTRUTOR PADRAO COM APENAS 1 ARGUMENTO USANDO A PALAVRA THIS
        public Produto()
        {
            Quantidade = 10;
        }
        //CONSTRUTOR 2 ARGUMENTOS COM THIS
        public Produto(string nome, double preco) : this() //OBTEM VALOR DO CONSTRUTOR PADRÃO
        {
            Nome = nome;
            Preco = preco;
        }

        //CONSTRUTOR 3 ARGUMENTOS COM THIS
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) //OBTEM VALOR DO CONSTRUTOR COM DOIS ARGUMENTOS
        {
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
