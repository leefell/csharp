namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T"); // Set para alterar
            Console.WriteLine(p.GetNome()); // Get para mostrar
            Console.WriteLine(p.GetPreco());
        }
    }
}