using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Ref_Out
{
    class Calculator
    {
        //não funciona pois esta dentro da variavel x e no programa principal esta A
        public static void Triple(int x)
        {
            x = x * 3;
        }

        //REF
        public static void TripleREF( ref int x)
        {
            x = x * 3;
        }

        //OUT
        public static void TripleOUT(int a, out int x)
        {
            x = a * 3;
        }


    }
}
