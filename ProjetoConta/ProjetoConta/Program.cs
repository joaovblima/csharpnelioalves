using System;
using System.Globalization;
namespace ProjetoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Conta conta = new Conta(titularConta, numeroConta);
            Console.Write("Haverá depósito inicial(s/n)? ");
            string verificaDeposito = Console.ReadLine();
            double novoDeposito;
            if(verificaDeposito == "s"){
                Console.Write("Entre o valor de depósito inicial: ");
                novoDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(novoDeposito);
            }
            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para depósito: ");
            novoDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(novoDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para saque: ");
            double novoSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(novoSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}