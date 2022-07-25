using System;
using System.Globalization;

namespace OrientacaoObjetoMetodoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------retangulo
            //Retangulo x = new Retangulo();
            //Console.WriteLine("Entre a largura e altura do retangulo");
            //x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("AREA: " + x.Area().ToString("F2",CultureInfo.InvariantCulture));
            //Console.WriteLine("PERIMETRO: " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL : " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            //--------------------------------------------------------------------------------------------------funcionario

            //Funcionario x = new Funcionario();
            //Console.Write("Nome:");
            //x.Nome = Console.ReadLine();
            //Console.Write("Salario Bruto:");
            //x.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.Write("Imposto:");
            //x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Funcionario: " + x);
            //Console.Write("Digite a porcentagem: ");
            //x.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            //Console.WriteLine("atualização : " + x);
            //Console.ReadKey();

            //--------------------------------------------------------------------------------------------------nota

            Nota x = new Nota();
            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Tres notas do aluno: ");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota final = " + x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if(x.Aprovado() == true)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTOU " + x.NotaRestante() + " PONTOS");
            }

        }
    }
}
