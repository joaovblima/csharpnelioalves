
using System.Globalization;
namespace TesteAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas dos alunos: ");
            double primeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double segundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double terceiraNota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno();
            aluno.Nome = nomeAluno;
            aluno.PrimeiraNota = primeiraNota;
            aluno.SegundaNota = segundaNota;
            aluno.TerceiraNota = terceiraNota;
            Console.WriteLine("Nota final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Aprovado());

        }   
    }
}