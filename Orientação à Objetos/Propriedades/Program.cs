namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Garrafa", 500.00, 10);

            produto.Nome = "Garrafa de Água";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);
        }
    }
}