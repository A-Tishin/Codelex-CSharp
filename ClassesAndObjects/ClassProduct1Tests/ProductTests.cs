using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassProduct1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassProduct;

namespace ClassProduct1.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void NewPriceTest_inputPriceUp_ProductNewPrice()
        {
            var phone = new Product("phone", 99.99m, 5);
            decimal newPrice = 119.99m;

            phone.NewPrice(newPrice);

            Assert.IsTrue(phone.Price == newPrice);
        }

        [TestMethod()]
        public void NewPriceTest_inputNegativePrice_NegativePriceCannotBeChanged()
        {
            decimal oldPrice = 99.99m;
            var phone = new Product("phone", oldPrice, 5);
            decimal newPrice = -119.99m;

            phone.NewPrice(newPrice);

            Assert.IsTrue(phone.Price == oldPrice);
        }

        [TestMethod()]
        public void SoldTest_ProdSold_StockExtract()
        {
            var phone = new Product("phone", 99.99m, 5);
            var amountAfterSale = 4;

            phone.Sold();

            Assert.IsTrue(amountAfterSale == phone.Stock);
        }

        [TestMethod()]
        public void SoldTest_ProdSold_ZeroIsZero()
        {
            var phone = new Product("phone", 99.99m, 0);
            var emptyStock = 0;

            phone.Sold();

            Assert.IsTrue(emptyStock == phone.Stock);
        }

        [TestMethod()]
        public void SupplyTest_input5_returnInputPlusStock()
        {
            var phone = new Product("phone", 99.99m, 1);
            var stockIn = 5;
            var newStock = 6;

            phone.Supply(stockIn);

            Assert.IsTrue(newStock == phone.Stock);
        }
    }
}