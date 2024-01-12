using Entities;

namespace delegateAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD case", 80.90));

            Action<Product> act = UpdatePrice;
            // p => { p.Price += p.Price * 0.1; }; //lambda

            list.ForEach(act);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            // aumenta o preco dos produtos em 10%
            p.Price += p.Price * 0.1;
        }

    }
}
