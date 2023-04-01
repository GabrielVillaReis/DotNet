using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(  ); CW TAB TAB BROKEN CHEAT
            /* string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"\nProdutos:\n{produto1}, cujo preço é {preco1:F2} \n{produto2}, cujo preço é {preco2:F2} \n");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}\n");
            Console.WriteLine("Medida com oito casas decimais:" + medida.ToString("F8") + "\nArredondado (três casas decimais):" + medida.ToString("F3") + "\nSeparador decimal invariant culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));
            
            
            string[] v = Console.ReadLine().Split(' ');
            string p1 = v[0];
            string p2 = v[1];
            Console.WriteLine(p1 + "\n" + p2);


            int i1 = int.Parse(Console.ReadLine());
            int i2 = i1 + 3;
            Console.WriteLine(i2);

            float f1 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(f1);
            Console.WriteLine(f1.ToString("F3", CultureInfo.InvariantCulture));
            */
            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] all = Console.ReadLine().Split(" ");

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(all[0] + "\n" + all[1] + "\n" + all[2]);

        }
    }
}