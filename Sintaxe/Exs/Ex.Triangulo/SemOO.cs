using System.Globalization;
namespace triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sem OO

            double x1, y1, z1, x2, y2, z2;
            double p1, p2;

            Console.WriteLine("Inserindo Medidas do triângulo X: ");
            string[] triangulo1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(triangulo1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(triangulo1[1], CultureInfo.InvariantCulture);
            z1 = double.Parse(triangulo1[2], CultureInfo.InvariantCulture);
            p1 = perimetro(x1, y1, z1);

            Console.WriteLine("Inserindo Medidas do triângulo Y: ");
            string[] triangulo2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(triangulo2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(triangulo2[1], CultureInfo.InvariantCulture);
            z2 = double.Parse(triangulo2[2], CultureInfo.InvariantCulture);
            p2 = perimetro(x2, y2, z2);

            double areaX = area(x1, y1, z1);
            double areaY = area(x2, y2, z2);

            Console.WriteLine("Área de X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }


        }

        static double perimetro(double a, double b, double c)
        {
            return (a + b + c )/ 2;
        }

        static double area(double a, double b, double c)
        {
            double p = perimetro(a, b, c);
            return Math.Sqrt(p*(p - a) * (p - b) * (p - c));
        }
    }
}
