using System;
using System.IO;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------TRY CATCH

            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    int result = n1 / n2;
            //    Console.WriteLine(result);
            //}
            //catch(DivideByZeroException) //tentar ser bem especifico
            //{
            //    Console.WriteLine("Não é permitido divisão por zero");
            //}
            ////catch (Exception e) //exception generico mas util
            ////{
            ////    Console.WriteLine("Error!" + e.Message);
            ////}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Formato errado! " + e.Message);
            //}

            //---------------------------------------------------------FINALLY

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally //FECHAR INDEPENDENTE DE ERRO OU SUCESSO
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }

        }
    }
}
