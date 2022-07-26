using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //FORMA RUIM

            //int s1 = Calculator_Ruim.Sum(2, 3);
            //Console.WriteLine(s1);

            //int s2 = Calculator_Ruim.Sum(2, 4, 3);
            //Console.WriteLine(s2);

            //int s4 = Calculator_Ruim.Sum(2, 3, 5, 6);
            //Console.WriteLine(s4);

            //FORMA BOA 
            //int s1 = Calculator_Bom_Vetor.Sum(new int[] { 2, 3 });
            //int s3 = Calculator_Bom_Vetor.Sum(new int[] { 2, 4, 3 });
            //int s4 = Calculator_Bom_Vetor.Sum(new int[] { 2, 3, 5, 6 });
            //Console.WriteLine(s1);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);

            //FORMA PERFECT COM PARAMS (não precisa instanciar)
            int s1 = Calculator_Perfect_Params.Sum(2, 3);
            int s3 = Calculator_Perfect_Params.Sum(2, 4, 3);
            int s4 = Calculator_Perfect_Params.Sum(2, 3, 5, 6);
            Console.WriteLine(s1);
            Console.WriteLine(s3);
            Console.WriteLine(s4);


        }
    }
}
