using exerciseProdutos;
using System.Collections.Generic;
using System.Globalization;
using exerciseProdutos.Entities;
namespace exerciseProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nProduct #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    produtos.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    produtos.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("\nPrice tags: ");
            foreach (Product produto in produtos)
            {
                Console.WriteLine(produto.PriceTag());
            }
        }
    }
}