using Entities;

namespace delegateFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // gerar uma nova lista com os nomes dos produtos em CAPS

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD case", 80.90));

            Func<Product, string> func = NameUpper;
            //Func<Product, string> func = p => p.Name.ToUpper(); // lambda

            List<string> resultado = list.Select(func).ToList();
            //List<string> resultado = list.Select(p => p.Name.ToUpper()).ToList(); // lambda 2
            //List<string> resultado = list.Select(NameUpper).ToList(); // nesse caso nao precisa do delegate
            foreach(string s in resultado)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
