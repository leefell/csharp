using System.Globalization;
namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] peca1 = Console.ReadLine().Split(' ');
            string cod1 = peca1[0];
            int qtd1 = int.Parse(peca1[1]);
            double preco1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            string cod2 = peca2[0]; 
            int qtd2 = int.Parse(peca2[1]);
            double preco2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double total = (qtd1 * preco1) + (qtd2 * preco2);

            Console.WriteLine("Total a pagar: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}