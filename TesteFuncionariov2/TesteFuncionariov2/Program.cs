using System;
using System.Globalization;
using TesteFuncionariov2;
namespace TesteFuncionalv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nome;
            funcionario.SalarioBruto = salario;
            funcionario.Imposto = imposto;

            Console.WriteLine("Funcionário: "+ funcionario);
            Console.Write("Digite a porcetagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine("Dados atualizados: "+ funcionario);
        }
    }
}