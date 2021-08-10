using Microsoft.VisualStudio.TestTools.UnitTesting;
using Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Account.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TransferTest_transferAtoB_makeMoneyFlow()
        {
            var acc1 = new Account("test", 200);
            var acc2 = new Account("dummy", 300);
            var endBalanceAcc1 = 100;
            var endBalanceAcc2 = 400;

            Program.Transfer(acc1, acc2, 100);

            Assert.AreEqual(endBalanceAcc1, acc1.Balance());
            Assert.AreEqual(endBalanceAcc2, acc2.Balance());
        }
    }
}