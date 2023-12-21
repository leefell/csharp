using exTotalTaxPayment.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace exTotalTaxPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data: ");
                Console.Write("Individual or company (i/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpendiures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpendiures, name, anualIncome));
                }
                else
                { 
                    Console.Write("Number of Employees: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add(new Company(n, name, anualIncome));
                }
            }

            double sum = 0.0;
            Console.WriteLine("\nTaxes paid: ");
            foreach(TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine(taxPayer.Name + ": $" + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}