using Microsoft.VisualStudio.TestTools.UnitTesting;
using Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void balanceTest_CreateAccountWithBalance_ReturnBalance()
        {
            double money = 150;
            var acc = new Account("test", money);

            var result = acc.Balance();

            Assert.IsTrue(money == result);
        }

        [TestMethod()]
        public void WithdrawalTest_WithdrawMoney_returnWithdrawedAndChangeAccountBalance()
        {
            var acc = new Account("test", 150);
            var toWithdraw = 50;
            var endBalance = 100;

            var result = acc.Withdrawal(toWithdraw);

            Assert.IsTrue(result == toWithdraw && acc.Balance() == endBalance);
        }

        [TestMethod()]
        public void DepositTest_deposit50_AccountDeposited50()
        {
            var acc = new Account("test", 150);
            var endBalance = 200;

            acc.Deposit(50);

            Assert.IsTrue(endBalance == acc.Balance());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var acc = new Account("test", 150);
            var endString = "test: 150";

            var result = acc.ToString();

            Assert.AreEqual(endString, result);
        }
    }
}