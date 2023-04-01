using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questão 1:

            /*
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite um número, para receber todos os números ímpares até esse numéro: ");

            for (int i = 1; i <= x; i+=2) { Console.WriteLine(i); }
            */

            // Questão 2:

            /*
            Console.Write("Digite a quantidade de números a serem digitados, o programa verificará quantos estão dentro do intervalo [10,20] e quantos estão fora: ");
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;
            for (int i = 0; i < n; i++) 
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) { dentro++; }
                else { fora++; }
            }
            Console.WriteLine($"\n{dentro} in \n{fora} out");
            */

            // Questão 3:

            /*
            Console.Write("Digite o número de casos a serem executados:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite 3 valores reais separados por espaço, o programa realizará a média ponderada desses 3 valores: ");
                string[] temp = Console.ReadLine().Split(" ");
                double v1 = double.Parse(temp[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(temp[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(temp[2], CultureInfo.InvariantCulture);
                double media = ((v1 * 2) + (v2 * 3) + (v3 * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            */

            // Questão 4:

            /*
            Console.Write("Digite o número de pares a serem divididos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split(" ");
                int v1 = int.Parse(temp[0]);
                int v2 = int.Parse(temp[1]);
                if (v2 == 0) { Console.WriteLine("Divisão Impossível"); }
                else { Console.WriteLine((double)v1 / v2); }
            }
            */

            // Questão 5:

            /*
            Console.Write("Digite um valor inteiro para calcular o seu fatorial: ");
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 0; i < n-1; i++)
            {
                fatorial *= (n - i);
            }

            Console.WriteLine(fatorial);
            */

            // Questão 6:

            /*
            Console.Write("Digite um número para saber todos os seus divisores:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0) { Console.WriteLine(i); }
            }
            */

            // Questão 7:

            /*
            Console.Write("Digite um número para saber os quadrados e cubos de todos os números até ele: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i,2), Math.Pow(i,3));
            }
            */
        }
    }
}
