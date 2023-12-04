using System.Globalization;
namespace exemploArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] array = new Produto[n];
            double soma = 0;

            // Faz a leitura dos dados e cria na memória
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os dados do produto: " + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                array[i] = new Produto { Nome = nome, Preco = preco };
                soma += array[i].Preco;
            }

            double precoMedio = soma / n;
            Console.WriteLine("Preço médio = " + precoMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}