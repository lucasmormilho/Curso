using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Calculator_Perfect_Params
    {
        public static int Sum(params int[] numeros) //PALAVRA PARAMS
        {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            return sum;
        }
    }
}
