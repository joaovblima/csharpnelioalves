using System.Globalization;
namespace TesteWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;

            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(CultureInfo.InvariantCulture));
            while (numero >= 0.0)
            {
                resultado = Math.Sqrt(numero);
                Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro nunero: ");
                numero = double.Parse(Console.ReadLine(CultureInfo.InvariantCulture));

            }
            Console.WriteLine("Número negativo");
        }
    }
}