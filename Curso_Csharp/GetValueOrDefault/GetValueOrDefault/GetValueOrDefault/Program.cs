using System;

namespace GetValueOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; //--nullable
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value); //----> se for direto da erro pois é null
            else
                Console.WriteLine("x is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y is null");

            // OPERADOR DE COALESCENCIA NULA

            double? a = null;
            double? b = 10;
            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);


        }
    }
}
