using System;
using System.Globalization;
namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double areaTriangulo = a * c /2 ;
            double pi = 3.14159;
            double areaCirculo = pi * (c * c);
            double areaTrapezio = (a + b) * c / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaRetangulo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}