using Entities;

namespace delegatePredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quero remover aqueles produtos que custam 100 ou mais

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0); // lambda, nesse caso nao precisaria criar a funcao ProductTest
            list.RemoveAll(ProductTest);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
