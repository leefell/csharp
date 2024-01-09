using Entities;

namespace comparandoIgualdadeHash
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<Product> produto = new HashSet<Product>();
            produto.Add(new Product("TV", 900.0));
            produto.Add(new Product("Notebook", 2000.0)); // isso é um objeto

            HashSet<Point> ponto = new HashSet<Point>();
            ponto.Add(new Point(3, 4));
            ponto.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 2000.0); // esse é outro objeto
            Console.WriteLine(produto.Contains(prod)); // output: false

            // Embora os dados sejam iguais, o Contains sinaliza que o prod não está contido
            // no HashSet produto, comparando as referencias de memória
        }
    }
}