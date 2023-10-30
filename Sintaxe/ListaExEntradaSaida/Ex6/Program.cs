using System.Globalization;
namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A, B, C;
            double triangulo, circulo, trapezio, quadrado, retangulo;

            string[] array1 = Console.ReadLine().Split(' ');
            A = double.Parse(array1[0], CultureInfo.InvariantCulture);
            B = double.Parse(array1[1], CultureInfo.InvariantCulture);
            C = double.Parse(array1[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("Area do Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Quadrado: " +  quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Retangulo: " +  retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}