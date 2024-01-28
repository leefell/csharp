namespace Exercício1
{
    internal class ConversorDeMoeda
    {

        public static double Iof = 6.0; // imposto

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }

    }
}
