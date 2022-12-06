using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarComInterface.Services
{
    class TaxaBrasil : IServicoTaxa //realização de interface
    {
        public double Taxa(double pagamento) //precisa ter o mesmo nome da operação para funcionar a interface
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
