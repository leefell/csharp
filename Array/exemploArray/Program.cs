using System.Globalization;

namespace exemploArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do array para alocação estática: ");
            int n =  int.Parse(Console.ReadLine());

            double[] array = new double[n];
            double soma = 0.0;

            for (int i  = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite a altura " + (i + 1) + ": " );
                array[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += array[i];
            }

            double media = soma/n;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}