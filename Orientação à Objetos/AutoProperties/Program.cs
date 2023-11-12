namespace AutoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Garrafa", 100.00, 10);

            produto.Nome = "T";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);

        }
    }
}