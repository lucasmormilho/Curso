using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicioContrato.Services
{
    class ServicoPagamentoPaypal : IPagamentoOnline
    {
        private const double PorcentagemTaxa = 0.02;
        private const double MesesInteresse = 0.01;


        public double Interesse(double pagamento, int meses)
        {
            return pagamento * MesesInteresse * meses;
        }

        public double TaxaPagamento(double pagamento)
        {
            return pagamento * PorcentagemTaxa;
        }
    }
}
