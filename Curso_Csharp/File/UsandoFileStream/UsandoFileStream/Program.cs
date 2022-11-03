using System;
using System.IO;


namespace UsandoFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //USANDO FILESTREAM
            //string path = @"C:\Aulas\File1.txt";
            //FileStream fs = null; //recurso externos necessario fechar
            //StreamReader sr = null; //recurso externos necessario fechar
            //try
            //{
            //    fs = new FileStream(path, FileMode.Open); //recurso externos necessario fechar
            //    sr = new StreamReader(fs); //recurso externos necessario fechar
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //    Console.ReadLine();
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally //tem que fechar mesmo se for erro ou não
            //{
            //    if (sr != null) sr.Close();
            //    if (fs != null) fs.Close();
            //}


            //---------------------------------------


            ////USANDO FILE
            //string path2 = @"C:\Aulas\File1.txt";
            //StreamReader sr2 = null; //recurso externos necessario fechar
            //try
            //{
            //    sr2 = File.OpenText(path2);
            //    string line2 = sr2.ReadLine();
            //    Console.WriteLine(line2);
            //    Console.ReadLine();
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally //tem que fechar mesmo se for erro ou não
            //{
            //    if (sr2 != null) sr2.Close();
            //}

            //USANDO FILE
            string path3 = @"C:\Aulas\File1.txt";
            StreamReader sr3 = null; //recurso externos necessario fechar
            try
            {
                sr3 = File.OpenText(path3);

                //ler todas linhas
                while (!sr3.EndOfStream)
                {
                    string line3 = sr3.ReadLine();
                    Console.WriteLine(line3);
                }
                Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally //tem que fechar mesmo se for erro ou não
            {
                if (sr3 != null) sr3.Close();
            }

        }
    }
}
