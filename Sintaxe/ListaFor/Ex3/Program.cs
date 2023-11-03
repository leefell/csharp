using System.Globalization;
namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de casos de Teste: ");
            int qtd = int.Parse(Console.ReadLine());

            double x, y, z;
            double ponderada = 0.0;

            for(int i = 0; i < qtd; i++)
            {
                Console.Write("Digite as três notas: ");
                string[] notas = Console.ReadLine().Split(' ');
                x = double.Parse(notas[0], CultureInfo.InvariantCulture);
                y = double.Parse(notas[1], CultureInfo.InvariantCulture);
                z = double.Parse(notas[2], CultureInfo.InvariantCulture);

                ponderada = ((x * 2) + (y * 3) + (z * 5)) / 10;
                Console.WriteLine(ponderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}