using System;

namespace AulaExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2022, 12, 14, 7, 10, 45);
            Console.WriteLine(data.ElapsedTime());

            string s1 = "Bom dia queridos estudantes!";
            Console.WriteLine(s1.Cut(10));

            //ao colocar o S1 e colocar o ponto vai aparecer os metodos
            //comuns, porem perceba que tem uma classificação abaixo
            //tem propriedades, metodos comuns e extensão

        }
    }
}
