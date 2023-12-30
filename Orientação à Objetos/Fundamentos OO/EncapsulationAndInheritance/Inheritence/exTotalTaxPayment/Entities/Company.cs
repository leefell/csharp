namespace exTotalTaxPayment.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployess { get; set; }
        public Company()
        {
        }
        public Company(int numberOfEmployess, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployess = numberOfEmployess;
        }

        public override double Tax()
        {
            if(NumberOfEmployess > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
