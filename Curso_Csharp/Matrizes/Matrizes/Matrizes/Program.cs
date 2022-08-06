using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] matriz = new double[2, 3];
            //Console.WriteLine(matriz.Rank);
            //Console.WriteLine(matriz.Length);
            //Console.WriteLine(matriz.GetLength(0));
            //Console.WriteLine(matriz.GetLength(1));

            Console.WriteLine("Digite o valor de N");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];
           
            for (var i = 0; i < n; i++) //linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int x = 0; x < n; x++) //colunas
                {
                    mat[i, x] = int.Parse(values[x]);
                }
            }

            Console.WriteLine("Valores diagonais");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int x = 0; x < n; x++)
                {
                    if (mat[i,x] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("numeros negativos: " + count);
        }
    }
}
