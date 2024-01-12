using Entities;
using System.Globalization;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Técnicas\Lambda, delegates & LINQ\texts\arq1.txt";

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(",");
                    string name = campos[0];
                    double price = double.Parse(campos[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name); // expressao LINQ completa

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
