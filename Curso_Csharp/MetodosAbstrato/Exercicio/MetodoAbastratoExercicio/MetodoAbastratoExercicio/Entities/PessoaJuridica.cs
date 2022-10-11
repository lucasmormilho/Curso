using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbastratoExercicio.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public int NFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int nFuncionarios) 
            : base(nome, rendaAnual)
        {
            NFuncionarios = nFuncionarios;
        }

        public override double Imposto()
        {
            if (NFuncionarios > 10)
            {
                return (RendaAnual * 14.0/100.0);
            }
            else
            {
                return (RendaAnual * 16.0/100.0);
            }
        }
    }
}
