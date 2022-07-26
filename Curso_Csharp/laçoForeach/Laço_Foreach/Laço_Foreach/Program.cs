using System;

namespace Laço_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };


            //COM FOREACH
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------");

            //COM FOR
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
