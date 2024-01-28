using Entities;
using System.Globalization;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Técnicas\Lambda, delegates & LINQ\texts\arq2.txt";

                Console.Write("Enter salary: ");
                double salary = double.Parse(Console.ReadLine());

                List<Employee> list = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] dados = sr.ReadLine().Split(",");
                        string name = dados[0];
                        string email = dados[1];
                        double employeeSalary = double.Parse(dados[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, employeeSalary));
                    }
                }

                var aboveSalary = list.Where(p => p.Salary > 2000.0).OrderBy(p => p.Name);
                Console.WriteLine("Email of people whose salary is more than 2000.00: ");
                foreach (Employee employee in aboveSalary)
                {
                    Console.WriteLine(employee.Email);
                }

                var sumSalary = list.Where(p => p.Name.StartsWith('M')).Select(p => p.Salary).Sum();
                Console.Write("Sum of salary of people whose name starts with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
