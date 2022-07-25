using System.Globalization;

namespace AutoProperties
{
    class Produto
    {
        //ATRIBUTO PRIVATIVO
        private string _nome { get; set; } 

        //AUTO PROPERTIES
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        //CONSTRUTORES
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        //CONSTRUTORES
        public Produto()
        {
        }

        //PROPERTIES CUSTOM
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) //VANTAGENS DE USAR REGRA
                {
                    _nome = value;
                }
                else
                {
                    _nome = "erro";
                }
            }
        }
        
        //OUTROS METODOS
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //OUTROS METODOS
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        //OUTROS METODOS
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //OUTROS METODOS
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Preco
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
