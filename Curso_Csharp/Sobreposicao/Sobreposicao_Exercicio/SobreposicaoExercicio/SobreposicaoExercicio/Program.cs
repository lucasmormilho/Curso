using System;
using System.Collections.Generic;
using System.Globalization;
using SobreposicaoExercicio.Entities;

namespace SobreposicaoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employees = int.Parse(Console.ReadLine());
            for (var x = 1; x <= employees; x++)
            {
                Console.WriteLine("Employee #" + x + " data:");
                Console.Write("Outsourced (y/n)?");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine().ToString();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Addicional:");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hour, value, additional));
                }
                else
                {
                    list.Add(new Employee(name, hour, value));
                }

                
            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture)); 
            }
        }
    }
}
