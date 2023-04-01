using System;
using System.Globalization;
namespace exercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão 1:

            /*
            Retangulo a;
            a = new Retangulo();
            Console.WriteLine("Entre com a altura e largura do triângulo: ");
            a.Altura = double.Parse(Console.ReadLine());
            a.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine(a);
            */

            // Questão 2:

            /*
            Funcionario a;
            a = new Funcionario();
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            a.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            a.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("\nFuncionário: " + a);
            Console.Write("\nDigite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine());
            a.AumentarSalario(aumento);
            Console.WriteLine("\nDados Atualizados: " + a);
            */

            // Questão 3:

            /*
            Aluno a;
            a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota final = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a.Aprovacao());
            */
        }
    }
}
