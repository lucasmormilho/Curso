using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarNoInterface.Services
{
    class TaxasBrasil
    {
        public double Taxa(double quantidade)
        {
            if(quantidade <= 100.0)
            {
                return quantidade * 0.2;
            }
            else
            {
                return quantidade * 0.15;
            }
        }
    }
}
