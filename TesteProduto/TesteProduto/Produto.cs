using System;
using System.Globalization;
namespace TesteProduto
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return quantidade * preco;
        }
        public void AdicionarProdutos(int quantidadeProduto)
        {
            quantidade += quantidadeProduto;
        }

        public void RemoverProdutos(int quantidadeProduto)
        {
            quantidade -= quantidadeProduto;
        }

        public override string ToString()
        {
            return nome + ", $ " + preco.ToString("F2", CultureInfo.InvariantCulture) 
                +", " + quantidade 
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
