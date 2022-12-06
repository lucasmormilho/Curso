using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicioContrato.Entities
{
    class Parcelas
    {
        public DateTime DataVencimento { get; set; }
        public double Quantidade { get; set; }

        public Parcelas(DateTime dataVencimento, double quantidade)
        {
            DataVencimento = dataVencimento;
            Quantidade = quantidade;
        }


        public override string ToString()
        {
            return "Aqui";
        }
    }
}
