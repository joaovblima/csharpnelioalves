using System;
using System.Collections.Generic;
using System.Globalization;
namespace TesteLista
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Quantos funcionarios você deseja registrar? ");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();
            for (int i = 1; i <= quantidadeFuncionarios; i++) {
                Console.WriteLine($"Funcionario #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine(" ");
                Funcionario funcionario = new Funcionario(id, nome, salario);
                funcionarios.Add(funcionario);
            }

            Console.Write("Entre o Id do funcionário que você quer dar aumento de salário: ");
            int idParaAumentoSalarial = int.Parse(Console.ReadLine());
            Funcionario funcionarioEncontrado = funcionarios.Find(x => x.Id == idParaAumentoSalarial); 

            if (funcionarioEncontrado != null)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                double porcentagemDoAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarioEncontrado.AumentarSalario(porcentagemDoAumento);
            } else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }


            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
