

namespace ProjetoConversorDeMoeda
{
    internal class ConversorMoeda
    {
        public static double ConverterDolar(double cotacaoMoeda, double quantidadeMoeda) {
            double conversaoComAcrescimo = cotacaoMoeda * quantidadeMoeda + (cotacaoMoeda * quantidadeMoeda * 0.06);
            return conversaoComAcrescimo;
            

        }

    }
}
