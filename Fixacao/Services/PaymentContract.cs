using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixacao.Entities;

namespace Fixacao.Services
{
    internal class PaymentContract
    {
        private IPaymentService _paymentService;
        public PaymentContract(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public void ProcessContract(Contrato contract, int mounth)
        {
            double basicQuiotaa = contract.TotalValue / mounth;
            for (int i = 1; i<= mounth; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuiotaa + _paymentService.PaymentRate(i, basicQuiotaa);
                double fullQuota = updateQuota + _paymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
