namespace ValorPeças
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código peça 1: ");
            int codigoPrimeiraPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de peças: ");
            int quantidadePrimeiraPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário: ");
            double valorPrimeiraPeca = double.Parse(Console.ReadLine());
            Console.WriteLine("\nCódigo peça 2: ");
            int codigoSegundaPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de peças: ");
            int quantidadeSegundaPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário: ");
            double valorSegundaPeca = double.Parse(Console.ReadLine());
            double totalAPagar = (quantidadePrimeiraPeca * valorPrimeiraPeca) + (quantidadeSegundaPeca * valorSegundaPeca);
            Console.WriteLine("VALOR A PAGAR: R$" + totalAPagar.ToString("F2"));

        }
    }
}