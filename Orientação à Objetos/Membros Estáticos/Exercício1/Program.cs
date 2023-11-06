using System.Globalization;
namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cotação do Dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares serão comprados: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em Reais: = " + total.ToString("F2", CultureInfo.InvariantCulture));

            
            

        }
    }
}