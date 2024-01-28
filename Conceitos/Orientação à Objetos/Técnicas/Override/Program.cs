using ex_Override.Entities;

namespace ex_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            // Conta comum taxa 5.0 | Conta poupança taxa 2.0 

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}