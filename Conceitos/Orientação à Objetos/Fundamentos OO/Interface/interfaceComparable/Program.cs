using Entities;

namespace interfaceComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Fundamentos OO\Interface\nomes.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> lista = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        lista.Add(new Employee(sr.ReadLine()));
                    }
                    lista.Sort(); // não tem como ordernar a lista se eu não souber como comparar um funcionário com o outro
                    foreach(Employee e in lista)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :/");
                Console.WriteLine(e.Message);
            }
        }
    }
}