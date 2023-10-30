using System.Collections.Specialized;
using System.Transactions;
using System.Globalization;
namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * (Math.Pow(raio, 2));

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}