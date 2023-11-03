using System.Globalization;
namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int x, y;
            double divisao = 0;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um par de números: ");
                string[] array = Console.ReadLine().Split(' ');
                x = int.Parse(array[0]);
                y = int.Parse(array[1]);

                if(y == 0)
                {
                    Console.WriteLine("Divisão Impossivel. ");
                }
                else
                {
                    divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}