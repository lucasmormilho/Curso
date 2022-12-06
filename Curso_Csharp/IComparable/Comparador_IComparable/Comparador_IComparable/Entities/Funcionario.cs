using System.Globalization;
using System;

namespace Comparador_IComparable.Entities
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string funcionario)
        {
            string[] vetor = funcionario.Split(",");
            Nome = vetor[0];
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome + " , " + Salario;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Erro do tipo de compareTo.");
            }
            //downcast
            Funcionario outro = obj as Funcionario;
            return Salario.CompareTo(outro.Salario); //MUITO LEGAL !!!
        }
    }
}
