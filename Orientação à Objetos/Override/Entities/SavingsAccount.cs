namespace ex_Override.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // Reimplementa na subclasse aquela operacao da superclasse e da um significado diferente à ela
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); // efetua o saque conforma a logica implementada na superclasse por causa do base
            Balance -= 2.0; // desconto
        }
    }
}