namespace TesteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numeroQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            string[] info = Console.ReadLine().Split(' ');
            string lastname = info[0];
            int idade = int.Parse(info[1]);
            double altura = double.Parse(info[2]);
            Console.WriteLine(nome);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(preco);
            Console.WriteLine(lastname);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

           
        }
    }
}