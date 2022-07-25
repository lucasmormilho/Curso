using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticosExercicio
{
    class CalcDolar
    {

        public static double iof = 6.0;

        public static double ConversorDeMoeda(double cotacao, double qtd)
        {
            double total = qtd * cotacao;
            return  total + total * iof / 100.0;
        }
    }
}
