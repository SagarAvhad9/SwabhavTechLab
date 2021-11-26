using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model.Tests
{
    [TestClass]
    public class LineItemTests
    {
        [TestMethod]
        public void LineItemTest()
        {
            LineItem lineItem = new LineItem(504, new Product(101, "Laptop", 30000, 0.5f), 1);
            Assert.IsTrue(lineItem.Quantity == 1);
            Assert.AreEqual<Product>(lineItem.Product, new Product(101, "Laptop", 30000, 0.5f));
        }
        [TestMethod]
        public void TestLineItemPrice()
        {
            LineItem lineItem = new LineItem(504, new Product(101, "Laptop", 30000, 0.5f), 1);
            Assert.AreEqual<double>(lineItem.Calculate(), 30000);
        }
    }
}