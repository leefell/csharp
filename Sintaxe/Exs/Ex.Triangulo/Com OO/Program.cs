using System.Globalization;
namespace triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Com OO

            Triangulo x, y, p;
            x = new Triangulo();
            y = new Triangulo();

            double p1, p2;

            Console.WriteLine("Inserindo Medidas do triângulo X: ");
            string[] triangulo1 = Console.ReadLine().Split(' ');
            x.A = double.Parse(triangulo1[0], CultureInfo.InvariantCulture);
            x.B = double.Parse(triangulo1[1], CultureInfo.InvariantCulture);
            x.C = double.Parse(triangulo1[2], CultureInfo.InvariantCulture);
            p1 = perimetro(x.A, x.B, x.C);

            Console.WriteLine("Inserindo Medidas do triângulo Y: ");
            string[] triangulo2 = Console.ReadLine().Split(' ');
            y.A = double.Parse(triangulo2[0], CultureInfo.InvariantCulture);
            y.B = double.Parse(triangulo2[1], CultureInfo.InvariantCulture);
            y.C = double.Parse(triangulo2[2], CultureInfo.InvariantCulture);
            p2 = perimetro(y.A, y.B, y.C);

            double areaX = x.calcArea();
            double areaY = y.calcArea();

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
    }
}