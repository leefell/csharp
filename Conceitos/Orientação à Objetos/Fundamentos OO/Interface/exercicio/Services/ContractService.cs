using Entities;

namespace Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int month)
        {
            double parcela = contract.TotalValue / month;
            for(int i = 0; i < month; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double novaParcela = parcela + _onlinePaymentService.interest(parcela, i);
                double totalParcela = novaParcela + _onlinePaymentService.paymentFee(novaParcela);
                contract.AddInstallment(new Installment(date, totalParcela));
            }
        }
    }
}
