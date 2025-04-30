namespace TesteSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            Console.Write("Digite a senha correta: ");
            int acesso = int.Parse(Console.ReadLine());
            while (acesso != senha )
            {
                Console.WriteLine("Senha Invalida.");
                Console.Write("Tente novamente: ");
                acesso = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}