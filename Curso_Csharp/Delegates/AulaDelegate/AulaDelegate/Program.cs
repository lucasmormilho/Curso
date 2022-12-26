using AulaDelegate.Services;
using System;

namespace AulaDelegate
{

    ////declarar delegate
    //delegate double OperacaoNumericaBinaria(double n1, double n2);

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double a = 10;
    //        double b = 12;

    //        OperacaoNumericaBinaria op = ServicoCalcular.Soma;

    //        ////sintaxe alternativas
    //        //OperacaoNumericaBinaria op2 = new OperacaoNumericaBinaria(ServicoCalcular.Soma);
    //        //double resultado2 = op.Invoke(a, b);

    //        double resultado = op(a, b);
    //        Console.WriteLine(resultado);
    //    }
    //}

    //-------------------------------------------------

    ////MULTIDELEGATE

    delegate void operacaoNumericaBinaria2(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            operacaoNumericaBinaria2 op = ServicoCalcular.ShowSum;

            //CONCATENA DUAS FUNÇÕES----MUITO LEGAL....
            op += ServicoCalcular.ShowMax;
            op.Invoke(a, b);

            //sintaxe alternativa
            //op(a, b);
        }

    }
}
