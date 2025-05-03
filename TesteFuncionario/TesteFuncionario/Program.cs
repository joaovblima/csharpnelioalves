using System.Globalization;

namespace TesteFuncionario
{
    class Program
    {
        static void Main(string[] args) {
            Funcionario funcionario = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primerio funcionaro: ");
            Console.Write("Nome: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.nome = nomeFuncionario;
            funcionario.salario = salario;

            Console.WriteLine("Dados do segundo funcionaro: ");
            Console.Write("Nome: ");
            nomeFuncionario = Console.ReadLine();
            Console.Write("Salario: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario2.nome = nomeFuncionario;
            funcionario2.salario = salario;

            double media = (funcionario.salario + funcionario2.salario) / 2;
            Console.WriteLine("Salario médio = " + media.ToString("F2"));


        }
    } }
