using System;
using System.Globalization;

namespace OrientacaoObjetoMetodo
{
    class Triangulo
    {
        public double A { get; set; } //ATRIBUTOS
        public double B { get; set; }
        public double C { get; set; }

        //CRIAR UM METODO / FUNCAO DENTRO DA CLASSE

        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

    }


}
