using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShippingApplication.Tests
{
    [TestClass()]
    public class OrderItemTests
    {
        OrderItem sampleOrderItem = new OrderItem(56, 43, 54);
        [TestMethod()]
        public void OrderItemTest()
        {
            Assert.AreEqual(56, sampleOrderItem.getGameId());
            Assert.AreEqual(43, sampleOrderItem.getOrderId());
            Assert.AreEqual(54, sampleOrderItem.getCost());
        }

        [TestMethod()]
        public void getGameIdTest()
        {
            Assert.AreEqual(56, sampleOrderItem.getGameId());
        }

        [TestMethod()]
        public void setGameIdTest()
        {
            sampleOrderItem.setGameId(32);
            Assert.AreEqual(32, sampleOrderItem.getGameId());
        }

        [TestMethod()]
        public void getOrderIdTest()
        {
            Assert.AreEqual(43, sampleOrderItem.getOrderId());
        }

        [TestMethod()]
        public void setOrderIdTest()
        {
            sampleOrderItem.setOrderId(85);
            Assert.AreEqual(85, sampleOrderItem.getOrderId());
        }

        [TestMethod()]
        public void getCostTest()
        {
            Assert.AreEqual(54, sampleOrderItem.getCost());
        }

        [TestMethod()]
        public void setCostTest()
        {
            sampleOrderItem.setCost(85);
            Assert.AreEqual(85, sampleOrderItem.getCost());
        }
    }
}