namespace SomaInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = int.Parse(Console.ReadLine());
            int segundoNumero = int.Parse(Console.ReadLine());
            int soma = primeiroNumero + segundoNumero;
            Console.WriteLine("SOMA: " + soma);
        }
    }
}