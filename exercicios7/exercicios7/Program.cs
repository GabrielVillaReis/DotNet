using System;
using System.Globalization;
using System.Security.Cryptography;

namespace exercicios7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1;
            Console.Write("Entre com o número da conta: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char c = char.Parse(Console.ReadLine());
            if(c == 's' || c.Equals('S'))
            // Por algum motivo, o == e o equals só funcionam ao usar '' e não usando "", não sei pq aspas duplas não funcionam
            {
                Console.Write("Entre com o número da conta: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(id, nome, saldo);
            }
            else {  c1 = new ContaBancaria(id, nome); }
            
            Console.WriteLine("\nDados da conta:\n{0}",c1);
            Console.Write("\nEntre um valor para depósito:");
            double deposito = double.Parse(Console.ReadLine());
            c1.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados:\n{0}", c1);
            Console.Write("\nEntre um valor para saque:");
            double saque = double.Parse(Console.ReadLine());
            c1.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados:\n{0}", c1);

        }
    }
}