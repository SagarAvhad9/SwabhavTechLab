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
    
        LineItem item = new LineItem(1, new Product(101, "Laptop", 30000, 0.5f), 1);
        Order order = new Order(1, DateTime.Today);

    public class OrderTests
    {
        [TestMethod]
        public void OrderTest()
        {
            Assert.AreEqual<int>(Order, 1);
            Assert.AreEqual<DateTime>(Order.GetDate, DateTime.Today);

        }

        [TestMethod]
        public void AddItemTest()
        {
            Order.AddItem(item);
            Assert.AreEqual<int>(Order., 0);

        }
    }
}