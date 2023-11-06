using System.Globalization;
using System.Runtime;

namespace Ex.Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            Console.WriteLine("Digite os dados do produto.");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nDigite a quantidade a ser adicionada ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);
            Console.WriteLine("Dados atualizados: " + produto);

            Console.Write("\nDigite a quantidade a ser removida do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}