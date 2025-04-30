namespace RaioCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formula da area = pi * raio * raio");
            double pi = 3.14159;
            Console.WriteLine($"Considere o valor de pi = {pi}");
            Console.WriteLine("Entrada: ");
            double raio = double.Parse(Console.ReadLine());
            double areaCirculo = pi * (raio * raio);
            Console.WriteLine("Saida: \nA=" + areaCirculo.ToString("F4"));
        }
    }
}