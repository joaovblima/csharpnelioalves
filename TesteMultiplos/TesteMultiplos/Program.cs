namespace TesteMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string multiplo;
            if (a % b == 0 || b % a == 0)
            {
                multiplo = "EH MULTIPLO";
            } else
            {
                multiplo = "NAO EH MULTIPLO";
            }
            Console.WriteLine(multiplo);
        }
    }
}