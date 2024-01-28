using System.Globalization;
namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor qualquer: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n < 0.0 || n > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (n <= 25)
            {
                Console.WriteLine("O numero: " + n + " se encontra no intervalo: (0,25)");
            }
            else if(n > 25 && n <= 50)
            {
                Console.WriteLine("O numero: " + n + " se encontra no intervalo: (25,50)");
            }
            else if(n > 50 && n <= 75)
            {
                Console.WriteLine("O numero: " + n + " se encontra no intervalo: (50,75)");
            }
            else if(n > 75 && n <= 100)
            {
                Console.WriteLine("O numero: " + n + " se encontra no intervalo: (75,100)");
            }
        }
    }
}