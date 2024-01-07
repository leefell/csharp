using Entities;
using Services;
using System.Globalization;

namespace restricoesGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Input the number of products that will be registered: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the name and price of product {i + 1} (name,price): " );
                string[] array = Console.ReadLine().Split(",");
                string name = array[0];
                double price = double.Parse(array[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("\nMax: " + max);
        }
    }
}