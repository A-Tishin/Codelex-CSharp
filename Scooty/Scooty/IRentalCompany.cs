using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooty
{
    public interface IRentalCompany
    {
        string Name { get; }

        void StartRent(string id);

        decimal EndRent(string id, DateTime endTime);

        decimal CalculateIncome(int? year, bool includeNotCompletedRentals);
    }
}
