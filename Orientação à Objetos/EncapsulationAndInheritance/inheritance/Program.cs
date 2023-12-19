using inheritance.Entities;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula 1
            BusinessAccount conta = new BusinessAccount(8010, "Callegari", 100.0, 500.0);
            Console.WriteLine(conta.Balance);
            //conta.Balance = 2; Erro, uma vez que o set está como protected e só pode ser acessada pela classe e subclasse

            // Aula 2
            Account acc = new Account(1001, "Tangerina", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Alexandre", 0.0, 500.0);

            // Upcasting - subclasse para superclasse

            Account acc1 = bacc; // A variável do tipo Account vai receber naturalmente qualquer objeto de uma subclasse dela
            Account acc2 = new BusinessAccount(1003, "Josué", 0.0, 200); // acc2 é um objeto do tipo BusinessAccount, mas está guardada em uma variável do tipo Account
            Account acc3 = new SavingsAccount(1004, "Marcelo", 0.0, 0.01);

            // DownCasting - superclasse para subclasse

            BusinessAccount acc4 = (BusinessAccount)acc2;
            // Necessário fazer o downcasting, o que importa pro compilador é o tipo da variável
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; Errado
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Updated.");
            }
        }
    }
}
