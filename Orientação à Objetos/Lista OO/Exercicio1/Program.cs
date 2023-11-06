using System.Globalization;
namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite a largura e altura do triângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}