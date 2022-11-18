using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarComInterface.Services
{
    class TaxaBrasil
    {
        public double Taxa(double pagamento)
        {
            if (pagamento <= 100)
            {
                return pagamento * 0.2;
            }
            else
            {
                return pagamento * 0.15;
            }
        }
    }
}
