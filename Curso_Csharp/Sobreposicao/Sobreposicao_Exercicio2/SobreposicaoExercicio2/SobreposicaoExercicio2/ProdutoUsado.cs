using System;
using System.Globalization;

namespace SobreposicaoExercicio2
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(DateTime dataFabricacao, string name, double preço)
            : base(name, preço)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string tagPreço()
        {
            return Name + " (usado) $ "
                + Preço.ToString("F2", CultureInfo.InvariantCulture)
                + " (Fabricado: " + DataFabricacao.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}
