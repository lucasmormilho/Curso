using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbastratoExercicio.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double GastoSaude { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude)
            : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000.00)
            {
                return (RendaAnual * 15.0/100.0)-(GastoSaude / 2);
            }
            else
            {
                return (RendaAnual * 25.0/100.0)-(GastoSaude / 2);
            }

        }
    }
}
