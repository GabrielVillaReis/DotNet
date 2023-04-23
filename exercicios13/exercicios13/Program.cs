using System;
using System.Globalization;
using exercicios13.Entities;



namespace exercicios13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> taxPayers = new List<Taxpayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Health expenditures: ");
                    int employeeNumb = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, income, employeeNumb));
                }
            }

            Console.WriteLine("\nTAXES PAID:\n");
            double totalTaxes = 0;
            foreach (Taxpayer taxpayer in taxPayers)
            {
                Console.WriteLine(taxpayer.Name + ": " + taxpayer.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += taxpayer.Taxes();
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}