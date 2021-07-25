using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _name;
        private double _balance;

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }
        public void ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                _balance = Math.Abs(_balance);
                Console.WriteLine($"{_name}, -${_balance:F2}.");
            }
            else
            {
                Console.WriteLine($"{_name}, ${_balance:F2}.");
            }
        }
    }
}
