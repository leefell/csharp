using System.Globalization;
using System.Collections.Generic;
using abstractsClasses.Entities;
namespace abstractsClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uma classe abstrata não pode ser diretamnete instanciada
            // Mesmo a classe account sendo abstrata, ela tem que existir para operacoes tipo calcular o saldo total das contas

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance; // Somando o balance de cada conta
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0); // Sacando 10 de cada conta
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Updated balance for account " + acc.Number + ": " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}