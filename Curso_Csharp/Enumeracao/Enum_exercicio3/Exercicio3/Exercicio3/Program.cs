using System;
using Exercicio3.Entities.Enums;
using Exercicio3.Entities;
using System.Globalization;


namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/yyyy): ");
            DateTime data_nascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            
            OrderStatus status =  Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Console.Write("How many itens to this order? ");
            int items = int.Parse(Console.ReadLine());

            Client cliente = new Client(name, email, data_nascimento);

            Order order = new Order(DateTime.Now, status, cliente);

            for (var x = 0; x < items; x++)
            {
                Console.WriteLine($"Enter #{x} item data: ");
                Console.Write("Product name: ");
                string name_product = Console.ReadLine();
                Console.Write("Product price: ");
                double price_product = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product produto = new Product(name_product, price_product);

                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qtd, price_product, produto);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY: ");
            Console.WriteLine(order);




        }
    }
}
