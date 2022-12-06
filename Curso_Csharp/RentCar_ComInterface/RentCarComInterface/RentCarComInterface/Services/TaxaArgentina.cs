using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarComInterface.Services
{
    class TaxaArgentina : IServicoTaxa
    {
        public double Taxa(double pagamento)
        {
            return pagamento + 10.00;
        }
    }
}
