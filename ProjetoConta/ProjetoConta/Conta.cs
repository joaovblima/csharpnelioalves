using System;
using System.Globalization;
namespace ProjetoConta
{
    internal class Conta
    {
        private string _nome;
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        
        public Conta(string nome, int numeroConta) {
            _nome = nome;
            NumeroConta = numeroConta;
        }
        public string getNome()
        {   
            return _nome;
        }

        public void setNome(string nome)
        {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            } 
        }


        public override string ToString()
        {
            return "Conta " + NumeroConta 
                    + " Titular " + _nome
                    + ", Saldo $ "+ Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if(valor > Saldo)
            {
                Console.WriteLine("Operação não permitida! Você não possui saldo o suficiente.");
            } else
            {
                Saldo -= valor + 5.00;
            }
        }
    }
}
