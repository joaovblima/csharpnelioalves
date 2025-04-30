namespace CalculaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero do funcionario: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de horas trabalhadas: ");
            int numeroHoras = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine());

            double valorSalario = numeroHoras * valorHora;
            Console.WriteLine("NUMERO: " + numero);
            Console.WriteLine("SALARIO: " + valorSalario.ToString("F2"));
        }
    }
}