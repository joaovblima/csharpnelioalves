namespace TesteFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar: ");
            int quantidadeNumeros = int.Parse(Console.ReadLine());
            int soma = 0;
            int num;
            for (int i = 1; i <= quantidadeNumeros; i++)
            {
                Console.Write($"Valor #{i}: ");
                num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("Soma = "+ soma);
        }
    }
}