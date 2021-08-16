using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooty
{
    public class Report
    {
        private string _scooterId;
        public decimal Bill { get;  }

        public Report(string id, decimal Bill)
        {
            _scooterId = id;
            this.Bill = Bill;
        }
    }
}
