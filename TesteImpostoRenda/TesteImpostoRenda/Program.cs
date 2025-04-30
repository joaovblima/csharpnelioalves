using System.Globalization;
namespace TesteImpostoRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua renda?");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;
            double calculaImposto;

            if (renda <= 2000.0) {
                Console.WriteLine("Isento");
            } else if (renda <= 3000.0)
            {
                imposto = 0.08;
                calculaImposto = (renda-2000) * imposto;
                Console.WriteLine("Você pagará R$" + calculaImposto.ToString("F2", CultureInfo.InvariantCulture) + " de imposto");
            } else if(renda <= 4500.0)
            {
                imposto = 0.18;
                calculaImposto = (renda - 3000.0) * imposto + 1000 * 0.08;
                Console.WriteLine("Você pagará R$" + calculaImposto.ToString("F2", CultureInfo.InvariantCulture) + " de imposto");
            } else
            {
                imposto = 0.28;
                calculaImposto = (renda - 4500.0) * imposto + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine("Você pagará R$" + calculaImposto.ToString("F2", CultureInfo.InvariantCulture) + " de imposto");
            }
        }
    }
}