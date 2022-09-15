using System.Globalization;

namespace SobreposicaoExercicio2
{
    class Produto
    {
        public string Name  { get; set; }
        public double Preço { get; set; }

        public Produto()
        {

        }

        public Produto(string name, double preço)
        {
            Name = name;
            Preço = preço;
        }

        public virtual string tagPreço()
        {
            return Name + " $ " 
                + Preço.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
