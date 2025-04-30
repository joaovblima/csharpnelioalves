namespace TestePosto
{
    class Program
    {
        static void Main(string[] args)
        {
            int contAlcool = 0;
            int contGasolina = 0;
            int contDiesel = 0;
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 4)
            {
                opcao = int.Parse((Console.ReadLine()));
                if (opcao == 1)
                {
                    contAlcool += 1;
                }
                else if (opcao == 2)
                {
                    contGasolina += 1;
                }
                else if (opcao == 3)
                {
                    contDiesel += 1;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+ contAlcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Diesel: " + contDiesel);
        }
    }
}