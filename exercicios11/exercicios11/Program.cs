using System.Globalization;
using exercicios11.Entities;
using exercicios11.Entities.Enums;

namespace exercicios11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,birthdate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());
            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product Name: ");
                string pname = Console.ReadLine();
                Console.Write("Product Price: ");
                double pprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(pname, pprice);
                OrderItem OrderItem = new OrderItem(quantity, pprice, product);
                order.AddItem(OrderItem);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.Write(order);
        }
    }
}