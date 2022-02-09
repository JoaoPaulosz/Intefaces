using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Services
{
    public  interface IPaymentService
    {
        public double PaymentFee(double amount);
        public double PaymentRate(int mounth, double amount);
    }
}
