using System.Globalization;
namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Digite uma coordenada (x,y): ");
            string[] array = Console.ReadLine().Split(' ');
            x = double.Parse(array[0], CultureInfo.InvariantCulture);
            y = double.Parse(array[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(x > 0 && y > 0)
            {
                Console.WriteLine("Quadrante 1.");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Quadrante 2.");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("Quadrante 3.");
            }
            else if(x > 0 && y < 0)
            {
                Console.WriteLine("Quadrante 4.");
            }

        }
    }
}