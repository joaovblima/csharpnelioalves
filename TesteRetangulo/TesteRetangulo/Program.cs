using System.Globalization;
using TesteRetangulo;

namespace TeteRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Retangulo retangulo = new Retangulo();
            retangulo.Largura = largura;
            retangulo.Altura = altura;
            Console.WriteLine("Area = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = "+ retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = "+ retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}