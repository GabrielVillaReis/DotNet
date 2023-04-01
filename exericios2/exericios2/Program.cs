using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Xml.Schema;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questão 1:

            /*
            int x1 = int.Parse(Console.ReadLine());

            if ( x1 < 0 )
            {
                Console.WriteLine("Número negativo");
            }
            else { Console.WriteLine("Numero não negativo"); }
            */

            // Questão 2:

            /*
            int x1 = int.Parse(Console.ReadLine());

            if(x1 % 2 == 0)
            {
                Console.WriteLine("é par");
            }
            else { Console.WriteLine("é impar"); }
            */

            // Questão 3:

            /*
            string[] s = Console.ReadLine().Split(" ");
            int x1 = int.Parse(x1[0]);
            int x2 = int.Parse(x1[1]);
            if (x1 % x2 == 0 || x2 % x1 == 0)
            {
                Console.WriteLine("São múltiplos");
            }

            else { Console.WriteLine("Não são múltiplos"); }
            */

            // Questão 4:

            /*
            string[] s = Console.ReadLine().Split(" ");
            int x1 = int.Parse(s[0]);
            int x2 = int.Parse(s[1]);
            int duracao;

            if (x1 >= x2)
            {
                duracao = 24 - x1 + x2;
            }
            else { duracao = x2 - x1; }

            Console.WriteLine("O jogo durou {0} hora(s)", duracao);
            */

            // Questão 5:

            /*
            string[] s = Console.ReadLine().Split(" ");
            int x1 = int.Parse(s[0]);
            int x2 = int.Parse(s[1]);
            double total = 0;

            if (x1 == 1)
            {
                total = 4.0 * x2;
            }
            else if (x1 == 2)
            {
                total = 4.5 * x2;
            }
            else if (x1 == 3)
            {
                total = 5.0 * x2;
            }
            else if (x1 == 4)
            {
                total = 2.0 * x2;
            }
            else if (x1 == 5)
            {
                total = 1.5 * x2;
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
            */

            // Questão 6:

            /*
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(x1 < 0 || x1 > 100) { Console.WriteLine("Fora de intervalo"); }
            else if(x1 > 0 && x1 <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(x1 <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if( x1 <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            */

            // Questão 7:

            /*
            string[] s = Console.ReadLine().Split(" ");
            float x = float.Parse(s[0], CultureInfo.InvariantCulture);
            float y = float.Parse(s[1], CultureInfo.InvariantCulture);
            if (x == 0 && y == 0) { Console.WriteLine("Origem"); }
            else if (x == 0) { Console.WriteLine("Y"); }
            else if (y == 0) { Console.WriteLine("X"); }
            else if (x > 0)
            {
                if (y > 0) { Console.WriteLine("Q1"); }
                else { Console.WriteLine("Q4"); }
            }
            else if (x < 0)
            {
                if (y > 0) { Console.WriteLine("Q2"); }
                else { Console.WriteLine("Q3"); }
            }
            else if (x == 0) { Console.WriteLine("Y"); }
            */

            // Questão 8:

            /*
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(salario <= 2000) { Console.WriteLine("Isento"); }
            else if(salario <= 3000) {
                Console.WriteLine("R$ {0}", ((salario - 2000) * 0.08).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500)
            {
                Console.WriteLine("R$ {0}", (1000 * 0.08 + (salario - 3000) * 0.18).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("R$ {0}", (1000 * 0.08 + 1500 * 0.18 + (salario - 4500) * 0.28).ToString("F2", CultureInfo.InvariantCulture));
            }
            */
        }
    }
}
