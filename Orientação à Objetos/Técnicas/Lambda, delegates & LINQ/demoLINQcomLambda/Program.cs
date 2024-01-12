﻿using Entities;

namespace demoLINQcomLambda
{
    internal class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            // Consulta com linq usando lambda
            var resultado1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("Tier 1 and Price < 900.00: ", resultado1);

            var resultado2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Name of products from tools: ", resultado2);

            //p => p.Name[0] == 'C'
            var resultado3 = products.Where(p => p.Name.StartsWith('C')).Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names stared with 'C' and Anonymous Object: ", resultado3);

            var resultado4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price and then by name: ", resultado4);

            var resultado5 = resultado4.Skip(2).Take(4);
            Print("Tier 1 order by Price then by name skip 2 take 4", resultado5);

            var resultado6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + resultado6);

            var resultado7 = products.Where(p => p.Price > 3000.0).FirstOrDefault(); // essa coleção vai ficar vazia
            Console.WriteLine("First or default test2: " + resultado7);

            var resultado8 = products.Where(p => p.Id == 3).SingleOrDefault(); // usar só quando retornar ou um ou nenhum elemento
            Console.WriteLine("\nSingle or default test1: " + resultado8);

            var resultado9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + resultado9);
        }
    }
}
