using System;
using System.Globalization;
namespace TesteVetorProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos produtos você vai ler? ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            Produtos[] produtos = new Produtos[quantidadeProdutos];

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preco: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i]= new Produtos(nomeProduto, precoProduto);
            }

            double media = 0;

            for (int i = 0;i < produtos.Length;i++)
            {
                media += produtos[i].PrecoProduto;
            }
            media = media / produtos.Length;
            Console.WriteLine("\nPreço medio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}