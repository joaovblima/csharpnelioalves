namespace TestePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            pessoa1.nome = nome;
            pessoa1.idade = idade;

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            pessoa2.nome = nome;
            pessoa2.idade = idade;

            if(pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha: "+ pessoa1.nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha: "+ pessoa2.nome);
            }
        }
        
    }
}