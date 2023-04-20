using System.Globalization;
using exercicios12.Entities;
namespace exercicios12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int nproducts = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            for (int i = 1; i <= nproducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customnsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customnsFee));
                }
                else if (c ==  'u') 
                {
                    Console.Write("Manufacturate date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    products.Add(new Product(name,price));
                }

            }

            Console.WriteLine("\nPRICE TAGS:\n");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}