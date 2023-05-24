using exercicios14.Entities;
using exercicios14.Entities.Exceptions;
namespace exercicios14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder:");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance:");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit:");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Account acc = new Account(number, holder, balance, withdrawLimit);
                Console.Write("\n\nEnter amount for withdraw:");
                double withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);
                Console.WriteLine("New balance {0}", acc.Balance);
            }
            catch (WithdrawException e) 
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }
        }
    }
}