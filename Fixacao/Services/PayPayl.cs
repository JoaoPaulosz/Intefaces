using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Services
{
    public class PayPayl : IPaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double PaymentRate(int mounth, double amount)
        {
            return amount * 0.01 * mounth;
        }
    }
}
