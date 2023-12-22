using BankExercise.Entities;
using BankExercise.Entities.Exceptions;
using System.Globalization;

namespace BankExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw Limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(n, holder, initialBalance, withDrawLimit);

            Console.Write("\nEnter the amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}