using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {

        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;


            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Media com 8 casas decimais: {media}");
            Console.WriteLine("Arredondando (três casas decimais) " + media.ToString("F3"));
            Console.WriteLine("Separador decimal invariante culture: "+ media.ToString("F3", CultureInfo.InvariantCulture));

        }

    }

}
   