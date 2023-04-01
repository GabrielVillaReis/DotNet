using System;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            // Questão 1:

            /*
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Soma = {0}", x1 + x2);
            */

            // Questão 2:

            /*
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("A = {0}", (Math.Pow(x1, 2) * pi).ToString("F4", CultureInfo.InvariantCulture));
            */

            // Questão 3:

            /*
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diferença = {0}", (x1 * x2) - (x3 * x4));
            */

            // Questão 4:

            /*
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Number = {0} \n Salary = U$ {1}", x1, (x2 * x3).ToString("F2", CultureInfo.InvariantCulture));
            */

            // Questão 5:

            /*
            string[] x1 = Console.ReadLine().Split(" ");
            string[] x2 = Console.ReadLine().Split(" ");

            double valor = (int.Parse(x1[1]) * double.Parse(x1[2], CultureInfo.InvariantCulture) + (int.Parse(x2[1]) * double.Parse(x2[2], CultureInfo.InvariantCulture)));
            Console.WriteLine("Valor a pagar: R$ {0}",valor.ToString("F2", CultureInfo.InvariantCulture));
            */

            // Questão 6:

            /*
            string[] x1 = Console.ReadLine().Split(" ");
            double A = double.Parse(x1[0], CultureInfo.InvariantCulture), B = double.Parse(x1[1], CultureInfo.InvariantCulture), C = double.Parse(x1[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Triangulo: {0:F3} \nCirculo: {1:F3} \nTrapezio: {2:F3} \nQuadrado: {3:F3} \nRetangulo: {4}", (A * C)/2, (Math.Pow(C,2) * pi).ToString("F3", CultureInfo.InvariantCulture), ((A + B) * C/2).ToString("F3", CultureInfo.InvariantCulture), (Math.Pow(B,2)).ToString("F3", CultureInfo.InvariantCulture), (A * B).ToString("F3", CultureInfo.InvariantCulture));
            */

        }
    }

}
