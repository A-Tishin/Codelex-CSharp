using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooty
{
    public class RentalCompany: ScooterService, IRentalCompany
    {
        public Accountant accountant = new Accountant();
        public string Name { get; }

        public RentalCompany(string name)
        {
            Name = name;
        }

        public void StartRent(string id)
        {
            var a = _scooterList.Find(x => x.Id == id);
            a.SessionStart = DateTime.Now;
            a.IsRented = true;
        }

        public decimal EndRent(string id, DateTime endTime)
        {
            var a = _scooterList.Find(x => x.Id == id);
            a.IsRented = false;
            var bill = accountant.CalcSessionPrice(a, a.SessionStart, endTime);
            accountant.AddReport(a, bill);
            return bill;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal totalIncome = 0;

            if (year.HasValue)
            {
                foreach (var report in accountant.reports[Convert.ToInt32(year)])
                {
                    totalIncome += report.Bill;
                }
            }
            else
            {
                foreach (var list in accountant.reports.Values)
                {
                    foreach (var report in list)
                    {
                        totalIncome += report.Bill;
                    }
                }
            }

            if (includeNotCompletedRentals)
            {
                foreach (var scooter in _scooterList)
                {
                    if (scooter.IsRented)
                    {
                        totalIncome += accountant.CalcSessionPrice(scooter, scooter.SessionStart, DateTime.Now);
                    }
                }
            }

            return totalIncome;
        }
    }
}
