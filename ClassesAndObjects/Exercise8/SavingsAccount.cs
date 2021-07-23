using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        private decimal _currentBalance;
        private decimal _totalDeposit;
        private decimal _totalWithdrawn;
        private decimal _totalInterest;

        public SavingsAccount(decimal deposit)
        {
            _currentBalance = deposit;
        }

        public void DepositToBalance(decimal depo)
        {
            _currentBalance += depo;
            _totalDeposit += depo;
        }

        public void WithdrawBalance(decimal withdraw)
        {
            _currentBalance -= withdraw;
            _totalWithdrawn -= withdraw;
        }

        public void MonthlyInterest(decimal rate)
        {
            decimal interest = ((rate / 100 / 12) + 1) * _currentBalance - _currentBalance;
            _currentBalance += interest;
            _totalInterest += interest;
        }

        public decimal TotalDeposited()
        {
            return _totalDeposit;
        }

        public decimal TotalWithdrawn()
        {
            return Math.Abs(_totalWithdrawn);
        }

        public decimal TotalInterest()
        {
            return Math.Round(_totalInterest, 2);
        }

        public decimal EndingBalance()
        {
            return Math.Round(_currentBalance, 2);
        }
    }
}
