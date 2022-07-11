using System;
using System.Globalization;

namespace OrientacaoObjetoMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------PROGRAMA SEM USAR METODO/FUNCAO
            //Triangulo x = new Triangulo(); //INSTANCIAR
            //Triangulo y = new Triangulo(); //INSTANCIAR

            //Console.WriteLine("Entre com as medidas do triangulo x:");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre com as medidas do triangulo y:");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (x.A + x.B + x.C) / 2.0;
            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            //Console.WriteLine("Area x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            //Console.WriteLine("Area y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior area é X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior area é Y");
            //}


            //------------------------------------------------PROGRAMA USANDO FUNCAO
            Triangulo x = new Triangulo(); //INSTANCIAR
            Triangulo y = new Triangulo(); //INSTANCIAR

            Console.WriteLine("Entre com as medidas do triangulo x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcularArea();
            Console.WriteLine("Area x: " + areaX);

            double areaY = y.CalcularArea();
            Console.WriteLine("Area y: " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area é X");
            }
            else
            {
                Console.WriteLine("Maior area é Y");
            }
        }
    }
}
