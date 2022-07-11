using System;

namespace ConversaoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão implicita");
            float x = 4.5f; //tem 4bytes

            double y = x; //tem 8 bytes

            Console.WriteLine(y); //----conversão implicita

            Console.WriteLine(" ");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Conversão explicita - casting");
            double a = 5.1;
            float b = (float)a; //casting ou conversão explicita
            Console.WriteLine(b);

            Console.WriteLine("Conversão explicita - casting");
            double aa = 5.1;
            int bb = (int)aa; //casting ou conversão explicita double para int perder valor se não converter
            Console.WriteLine(bb);

            Console.WriteLine("Conversão explicita - casting");
            int aaa = 5;
            int bbb = 2; //casting ou conversão explicita int para double perder valor se não converter

            double resultado = (double)aaa / (double)bbb;

            Console.WriteLine(resultado);



        }
    }
}
