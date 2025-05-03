namespace TesteAlugel
{
    class Program
    {
        static void Main(string[] args)
        {
       

            Console.Write("Quantos quartos serão alugados? ");
            int numeroQuartos = int.Parse(Console.ReadLine());
            RegistroAlugel[] alugueis = new RegistroAlugel[9];

            for (int i = 1; i <= numeroQuartos; i++)
            {
                Console.Write($"Aluguel #{i} ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                RegistroAlugel vect = new RegistroAlugel(nome, email);
                alugueis[quarto] = vect;
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < alugueis.Length; i++)
            {
                if (alugueis[i] != null)
                {
                    Console.WriteLine($"#{i}: {alugueis[i].Nome}, {alugueis[i].Email}");
                }
            }
        }
    }
}