using System;
using System.Globalization;

namespace MembrosEstaticosCalcInstancia
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //ESTATICO NÃO PRECISA INSTANCIAR
            //ESTATICO NÃO PRECISA INSTANCIAR
            //ESTATICO NÃO PRECISA INSTANCIAR
            //ESTATICO NÃO PRECISA INSTANCIAR
            //ESTATICO NÃO PRECISA INSTANCIAR
            //ESTATICO NÃO PRECISA INSTANCIAR

            Console.WriteLine(Calculadora.Pi); //estatico direto na classe
            Console.WriteLine(Calculadora.Pi); //estatico direto na classe

            Console.WriteLine("Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Calculadora.Pi);
        }

        //classe estatica faz um função indepentende do objeto ou instancia
        //CLASSES ESTATICAS


    }
}
