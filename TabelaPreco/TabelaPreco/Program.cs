namespace TabelaPreco
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("----- TABELA PRECO -----");
            Console.WriteLine("1 - Cachorro Quente R$ 4.00");
            Console.WriteLine("2 - X-Salada R$ 4.50");
            Console.WriteLine("3 - X-Bacon R$ 5.00");
            Console.WriteLine("4 - Torrada Simples R$ 2.00");
            Console.WriteLine("5 - Refrigerante R$ 1.50");

            Console.WriteLine("O que deseja pedir: ");
            int numeroPedido = int.Parse(Console.ReadLine());
            Console.WriteLine("E a quantidade: ");
            int quantidadePedido = int.Parse(Console.ReadLine());
            double totalPagar;

            switch (numeroPedido)
            {
                default:
                    Console.WriteLine("Valor inválido");
                    break;
                case 1:
                    totalPagar =  4.00 * quantidadePedido;
                    Console.WriteLine("TOTAL A PAGAR É: R$"+ totalPagar.ToString("F2"));
                    break;
                case 2:
                    totalPagar = 4.50 * quantidadePedido;
                    Console.WriteLine("TOTAL A PAGAR É: R$" + totalPagar.ToString("F2"));
                    break;
                case 3:
                    totalPagar = 5.00 * quantidadePedido;
                    Console.WriteLine("TOTAL A PAGAR É: R$" + totalPagar.ToString("F2"));
                    break;
                case 4:
                    totalPagar = 2.00 * quantidadePedido;
                    Console.WriteLine("TOTAL A PAGAR É: R$" + totalPagar.ToString("F2"));
                    break;
                case 5:
                    totalPagar = 1.50 * quantidadePedido;
                    Console.WriteLine("TOTAL A PAGAR É: R$" + totalPagar.ToString("F2"));
                    break;
            }
        }
    }
}