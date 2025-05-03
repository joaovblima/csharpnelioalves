using System.Globalization;

namespace TesteAluno
{
    internal class Aluno
    {
        public string Nome;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;


        public double Media()
        {
            return (PrimeiraNota + SegundaNota + TerceiraNota) / 3;
        }

        public double NotaFinal()
        {
            return PrimeiraNota + SegundaNota + TerceiraNota;
        }
        public string Aprovado()
        {
            return NotaFinal() >= 60.0 ? "APROVADO" : "REPROVADO";
        }
    }
}
