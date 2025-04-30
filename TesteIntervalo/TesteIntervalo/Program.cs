namespace TesteIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero < 25)
            {
                Console.WriteLine("Intervalo [0, 25]");

            }
            else if (numero < 50)
            {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (numero < 75)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else if (numero < 100)
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
        }
    }
}