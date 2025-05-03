using System.Globalization;

namespace TesteProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade estoque: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            Produto produto = new Produto();
            produto.nome = nomeProduto;
            produto.preco = precoProduto;
            produto.quantidade = quantidadeProduto;

            Console.WriteLine("Dados do produto: " + produto);

            Console.Write("Digite o numero de produtos a ser adicionados ao estoque: ");
            int novoEstoque = int.Parse(Console.ReadLine());
            
            produto.AdicionarProdutos(novoEstoque);
            
            Console.WriteLine("Dados atualizados: "+ produto);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            novoEstoque = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(novoEstoque);

            Console.WriteLine("Dados atualizados: " + produto);

            


        }
    }
}