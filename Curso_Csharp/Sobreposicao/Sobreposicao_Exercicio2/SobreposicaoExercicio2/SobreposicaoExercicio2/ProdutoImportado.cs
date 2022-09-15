using System.Globalization;

namespace SobreposicaoExercicio2
{
    class ProdutoImportado : Produto
    {
        public double Taxa { get; set; }

        public ProdutoImportado()
        {

        }

        public ProdutoImportado(double taxa, string name, double preço)
            : base(name, preço)
        {
            Taxa = taxa;
        }

        public override string tagPreço()
        {
            return Name + " $ " 
                + PreçoTotal().ToString("F2", CultureInfo.InvariantCulture) 
                + "(Taxa: $ " + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

        public double PreçoTotal()
        {
            return Preço + Taxa;
        }
    }


}
