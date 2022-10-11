using System;
using System.Collections.Generic;
using MetodoAbstrato.Entities;
using MetodoAbstrato.Entities.Enums;
using System.Globalization;

namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(var i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Retangle or circle (r/c) ? :");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black, Blue or Red) ? :");
                Color color = Enum.Parse<Color>(Console.ReadLine()); //ler enums
                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heith: ");
                    double heith = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangle(width, heith, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius,color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape item in list)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
