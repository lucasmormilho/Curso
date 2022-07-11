using System;

namespace OpComparativos
{
    class Program
    {
        static void Main(string[] args)
        {

            //OPERADORES COMPARATIVOS
            int a = 10;
            bool b = a < 10;
            Console.WriteLine(b);
            bool c = a == 10;
            Console.WriteLine(c);
            bool d = a > 9;
            Console.WriteLine(d);
            Console.WriteLine("--------------------------------");


            //OPERADORES LOGICOS
            bool c1 = 2 > 3 && 4 != 5; //---e -->FALSE
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5; //---OU -->TRUE
            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5; //---Precedencia Não ---TRUE
            Console.WriteLine(c3);

            bool c4 = 10 < 5; //-->FALSE
            bool c5 = c2 || c3 && c4;
            Console.WriteLine(c5);
        }
    }
}
