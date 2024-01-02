using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShippingApplication.Tests
{
    [TestClass()]
    public class OrderTests
    {
        Order sampleOrder = new Order(64, 32, "12-MAY-2023", "Placed", 6);
        [TestMethod()]
        public void OrderTest()
        {
            Assert.AreEqual(64, sampleOrder.getOrderId());
            Assert.AreEqual(32, sampleOrder.getCost());
            Assert.AreEqual("12-MAY-2023", sampleOrder.getDate());
            Assert.AreEqual("Placed", sampleOrder.getStatus());
            Assert.AreEqual(6, sampleOrder.getCustId());
        }

        [TestMethod()]
        public void getOrderIdTest()
        {
            Assert.AreEqual(64, sampleOrder.getOrderId());
        }

        [TestMethod()]
        public void setOrderIdTest()
        {
            sampleOrder.setOrderId(92);
            Assert.AreEqual(92, sampleOrder.getOrderId());
        }

        [TestMethod()]
        public void getDateTest()
        {
            Assert.AreEqual("12-MAY-2023", sampleOrder.getDate());
        }

        [TestMethod()]
        public void setDateTest()
        {
            sampleOrder.setDate("23-JUN-2023");
            Assert.AreEqual("23-JUN-2023", sampleOrder.getDate());
        }

        [TestMethod()]
        public void getCostTest()
        {
            Assert.AreEqual(32, sampleOrder.getCost());
        }

        [TestMethod()]
        public void setCostTest()
        {
            sampleOrder.setCost(85);
            Assert.AreEqual(85, sampleOrder.getCost());
        }

        [TestMethod()]
        public void getCustIdTest()
        {
            Assert.AreEqual(6, sampleOrder.getCustId());
        }

        [TestMethod()]
        public void setCustIdTest()
        {
            sampleOrder.setCustId(32);
            Assert.AreEqual(32, sampleOrder.getCustId());
        }

        [TestMethod()]
        public void getStatusTest()
        {
            Assert.AreEqual("Placed", sampleOrder.getStatus());
        }

        [TestMethod()]
        public void setStatusTest()
        {
            sampleOrder.setStatus("Cancelled");
            Assert.AreEqual("Cancelled", sampleOrder.getStatus());
        }
    }
}