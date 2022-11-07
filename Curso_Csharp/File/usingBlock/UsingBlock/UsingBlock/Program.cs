using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            //COM DOIS BLOCOS DE USING

            //string path = @"C:\Aulas\File1.txt";
            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open)) //bloco que se fecha automaticamente sem precisar usar finally
            //    {
            //        using (StreamReader sr = new StreamReader(fs)) //bloco que se fecha automaticamente sem precisar usar finally
            //        {

            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }

            //        }
            //    }
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //------------------------------------------COM 1 BLOCO DE USING
            string path = @"C:\Aulas\File1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path)) //bloco que se fecha automaticamente sem precisar usar finally
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
