namespace DuracaoJogo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("inicio do jogo: ");
            int horaInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("termino do jogo:");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;

            if (horaInicio < horaFinal)
            {
                duracao = horaFinal - horaInicio;
            }
            else 
            {
                duracao = 24 - horaInicio + horaFinal;            
            }
            Console.WriteLine($"o jogo durou {duracao} horas");
        }
    }
}