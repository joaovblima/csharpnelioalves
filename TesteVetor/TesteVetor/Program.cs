using System;
using System.Globalization;
namespace TesteVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] valores = new double[n];
            for (int i = 0; i < valores.Length; i++)
            {
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                valores[i] = valor;
            }
            double media = 0;
            for (int i = 0; i < valores.Length;i++)
            {
                media += valores[i];
            }
            Console.WriteLine(media/valores.Length.ToString(CultureInfo.InvariantCulture);


        }
    }
}