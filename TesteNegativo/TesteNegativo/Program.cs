namespace TesteNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("POSITIVO");
            }
        }
    }
} 