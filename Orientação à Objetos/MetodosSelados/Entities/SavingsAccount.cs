namespace MetodosSelados.Entities
{
    // Com o sealed, a classe SavinsAccount não pode ter subclasses
    sealed internal class SavingsAccount : Account
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

        // Essa operação não pode ser sobrescrita novamente em uma outra subclasse, caso a classe nao seja selada
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount); // efetua o saque conforma a logica implementada na superclasse por causa do base
            Balance -= 2.0; // desconto
        }
    }
}