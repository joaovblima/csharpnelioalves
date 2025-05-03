using System;
using System.Globalization;
namespace ProjetoConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo = ConversorMoeda.ConverterDolar(cotacaoDolar, quantidadeDolar);
            Console.Write("Valor a ser pago em reais = " + calculo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}