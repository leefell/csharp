using System.Globalization;
namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Tudo vai depender dos argumentos aqui, se for passados tres argumentos, ele vai chamar um construtor, se dois outro, se nenhum outro.
            Produto p = new Produto(nome, preco);
            Produto p2 = new Produto();




            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

             // Sintaxe Alternativa para iniciar valores
            // Produto p3 = new Produto{
            //    nome = "tv",
           //     Preco = 500.00,
           //     Quantidade = 20
           // }; Semelhante ao struct do c++
        }
    }
}