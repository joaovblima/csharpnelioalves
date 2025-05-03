using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVetorProdutos
{
    internal class Produtos
    {
        public string NomeProduto {  get; set; }
        public double PrecoProduto { get; private set; }

        public Produtos(string nome, double preco) {
            NomeProduto = nome;
            PrecoProduto = preco;
        }
    }
}
