using System.Globalization;
using System;

namespace Encapsulamento
{
    class Produto
    {
        private string _nome;//nome padrão por convensão quando privativo
        private double _preco;
        private int _quantidade;

        //--------------------------------ENCAPSULAMENTO NOME GET/SET
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)  //NOME PODE SER MODIFICADO
        {
            if (nome != null && nome.Length > 1) //VANTAGENS DE USAR REGRA
            {
                _nome = nome;
            }
            else
            {
                _nome = "erro";
            }
            
        }

        //--------------------------------ENCAPSULAMENTO PRECO GET
        public double GetPreco()
        {
            return _preco;
        }

        //--------------------------------ENCAPSULAMENTO QUANTIDADE GET
        public double GetQuantidade()
        {
            return _quantidade;
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
