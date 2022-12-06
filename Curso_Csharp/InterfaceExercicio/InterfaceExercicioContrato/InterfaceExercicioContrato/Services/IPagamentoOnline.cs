using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicioContrato.Services
{
    interface IPagamentoOnline
    {
        double TaxaPagamento(double pagamento);
        double Interesse(double pagamento, int meses);
    }
}
