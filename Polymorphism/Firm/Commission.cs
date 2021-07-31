using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Commission: Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commission)
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commission;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            return base.Pay() + _commissionRate * _totalSales;

        }

        public override string ToString()
        {
            var sales = base.ToString();
            sales += "\nTotal sales: " + _totalSales;
            return sales;
        }
    }
}
