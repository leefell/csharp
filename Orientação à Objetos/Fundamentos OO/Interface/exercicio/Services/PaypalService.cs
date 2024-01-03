namespace Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double paymentFee(double amount)
        {
            return amount * FeePercentage;
        }

        public double interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
