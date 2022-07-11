using System;
using System.Globalization;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------PROGRAMA SEM ORIENTAÇÃO A OBJETO
            //double xA, xB, xC, yA, yB, yC;
            //Console.WriteLine("Entre com as medidas do triangulo x:");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre com as medidas do triangulo y:");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            //Console.WriteLine("Area x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            //Console.WriteLine("Area y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior area é X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior area é Y");
            //}




            //---------------------------------------------PROGRAMA COM ORIENTAÇÃO A OBJETO

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

            //-----------------------------------------------------------EXERCICIO 1

            //Pessoa A = new Pessoa();
            //Pessoa B = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //A.nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //A.idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //B.nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //B.idade = int.Parse(Console.ReadLine());
            //if (A.idade > B.idade)
            //{
            //    Console.WriteLine("Mais velha: " + A.nome);
            //}
            //else
            //{
            //    Console.WriteLine("Mais velha: " + B.nome);
            //}

            //-----------------------------------------------------------EXERCICIO 2

            Funcionario A = new Funcionario();
            Funcionario B = new Funcionario();

            Console.WriteLine("Dados do primeiro:");
            Console.Write("Nome: ");
            A.nome = Console.ReadLine();
            Console.Write("Salario: ");
            A.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segunda:");
            Console.Write("Nome: ");
            B.nome = Console.ReadLine();
            Console.Write("Salario: ");
            B.salario = double.Parse(Console.ReadLine());
            if (A.salario > B.salario)
            {
                Console.WriteLine("Mais grana: " + A.nome);
            }
            else
            {
                Console.WriteLine("Mais grana: " + B.nome);
            }

        }

    }
}
