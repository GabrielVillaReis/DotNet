using System;
using System.Globalization;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questão 1:

            /*
            Console.Write("Digite a sua senha:");
            int input = int.Parse(Console.ReadLine());
            while (input != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite a sua senha:");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            */

            // Questão 2:

            /*
            Console.Write("Digite as coordenas:");
            string[] s = Console.ReadLine().Split(" ");
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            while (x != 0 && y != 0) 
            {
                if( x > 0 )
                {
                    if( y > 0 ) { Console.WriteLine("Primeiro Quadrante"); }
                    else { Console.WriteLine("Quarto Quadrante"); }
                }
                else
                {
                    if( y > 0 ) { Console.WriteLine("Segundo Quadrante"); }
                    else { Console.WriteLine("Terceiro Quadrante"); }
                }
                Console.Write("Digite as coordenas:");
                s = Console.ReadLine().Split(" ");
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
            }
            */

            // Questão 3:

            /*
            Console.WriteLine("Digite o tipo número do tipo de combústivel abastecido( 4 finalizará a execução ):");
            int tipo = 10;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (tipo != 4)
            {
                tipo = int.Parse(Console.ReadLine());
                if (tipo == 1) { alcool += 1; }
                else if(tipo == 2) {  gasolina += 1; }
                else if(tipo == 3) {  diesel += 1; }
                else if(tipo == 4) { Console.WriteLine($"Muito Obrigado \nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}"); }
            }
            */
        }
    }
}
