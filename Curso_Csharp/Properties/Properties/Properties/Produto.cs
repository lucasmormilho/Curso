using System.Globalization;

namespace Properties
{
    class Produto
    {
        private string _nome; //nome padrão por convensão quando privativo
        private double _preco;
        private int _quantidade;


        //PROPERTIES
        public string Nome { 
            get { return _nome; }
            set {
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

        //PROPERTIES
        public double  Preco {
            get { return _preco; } 
        }

        //PROPERTIES
        public double Qtd
        {
            get { return _quantidade; }
        }


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
