using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooty
{
    public class Accountant
    {
        public Dictionary<int, List<Report>> reports = new ();

        public decimal CalcSessionPrice(Scooter scooter, DateTime sessionStart, DateTime sessionEnd)
        {
            decimal price = 0;
            var dayCount = sessionEnd.DayOfYear - sessionStart.DayOfYear;
            if (sessionStart.DayOfYear != sessionEnd.DayOfYear)
            {
                var firstDayBill = ((23 - sessionStart.Hour) * 60 + (59 - sessionStart.Minute)) * scooter.PricePerMinute;
                var lastDayBill = (sessionEnd.Hour * 60 + sessionEnd.Minute) * scooter.PricePerMinute;
                if (dayCount > 1)
                {
                    price += 20 * (dayCount - 1);
                }

                var floorTo20FirstDay = firstDayBill > 20 ? price += 20 : price += firstDayBill;
                var floorTo20LastDay = lastDayBill > 20 ? price += 20 : price += lastDayBill;
                return price;
            }

            var rentTime = sessionEnd.Subtract(sessionStart);
            price += (rentTime.Hours * 60 + rentTime.Minutes) * scooter.PricePerMinute;
            if (price > 20)
            {
                price = 20;
            }
            return price;
        }

        public void AddReport(Scooter scooter, decimal bill)
        {
            if (!reports.ContainsKey(DateTime.Now.Year))
            {
                reports.Add(DateTime.Now.Year, new List<Report> { new(scooter.Id, bill) });
                return;
            }

            reports[DateTime.Now.Year].Add(new Report(scooter.Id, bill));
        }
    }
}
