using System;

namespace Params_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //não funciona pois esta dentro da variavel x e no programa principal esta A
            int a = 10;
            Calculator.Triple(a);
            Console.WriteLine(a);

            //REF
            int a2 = 10;
            Calculator.TripleREF( ref a2);
            Console.WriteLine(a2);

            //OUT
            int a3 = 10;
            int TripleOUT;
            Calculator.TripleOUT(a3, out TripleOUT);
            Console.WriteLine(TripleOUT);
        }
    }
}
