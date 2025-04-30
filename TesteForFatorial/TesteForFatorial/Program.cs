namespace TesteForFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o numero? ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            Console.WriteLine(resultado);
        }
    }
}