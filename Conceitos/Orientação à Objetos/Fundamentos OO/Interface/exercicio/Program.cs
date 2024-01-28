using Entities;
using Services;
using System.Globalization;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract1 = new Contract(n, date, contract);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract1, months);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in contract1.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}