using System;

namespace MatrizExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separados = Console.ReadLine().Split(' ');

            int[,] mat = new int[int.Parse(separados[0]), int.Parse(separados[1])];

            for (var i = 0; i < int.Parse(separados[0]); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int x = 0; x < int.Parse(separados[1]); x++)
                {
                    mat[i, x] = int.Parse(values[x]);
                }
            }
            int numeroChave = int.Parse(Console.ReadLine());

            for (int i = 0; i < int.Parse(separados[0]); i++)
            {
                for (int x = 0; x < int.Parse(separados[1]); x++)
                {
                    if (mat[i, x] == numeroChave)
                    {
                        Console.Write("Position ");
                        Console.Write(i + "," + x);
                        Console.WriteLine();
                        if (x > 0)
                        {
                            Console.Write("Left ");
                            Console.Write(mat[i, x - 1]);
                            Console.WriteLine();
                        }
                        if (i > 0)
                        {
                            Console.Write("UP ");
                            Console.Write(mat[i - 1, x]);
                            Console.WriteLine();
                        }
                        if (x < int.Parse(separados[1]) - 1)
                        {
                            Console.Write("Right ");
                            Console.Write(mat[i, x + 1]);
                            Console.WriteLine();
                        }
                        if (i < int.Parse(separados[0]) - 1)
                        {
                            Console.Write("Down ");
                            Console.Write(mat[i + 1, x]);
                            Console.WriteLine();
                        }

                    }

                }
            }
        }
    }
}
