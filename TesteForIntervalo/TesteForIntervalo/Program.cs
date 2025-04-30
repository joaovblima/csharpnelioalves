namespace TesteForIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quatidade de vezes que você digitará: ");
            int quantidade = int.Parse(Console.ReadLine());
            int inIntervalo = 0;
            int outIntervalo = 0;
            int numeros;

            for (int i = 0; i < quantidade; i++)
            {
                numeros = int.Parse(Console.ReadLine());
                if (numeros < 10 || numeros > 20)
                {
                    outIntervalo += 1;
                }
                else
                {
                    inIntervalo += 1;
                }

            }
            Console.WriteLine($"{inIntervalo} in");
            Console.WriteLine($"{outIntervalo} out");
        }
    }
}