using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Entities
{
    public class Contrato
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contrato(int number, DateTime date, double totalValue, Installment installments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            this.installments = installments;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
