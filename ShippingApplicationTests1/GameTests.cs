using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShippingApplication.Tests
{
    [TestClass()]
    public class GameTests
    {
        //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        Game thisGame = new Game(65, "Title", "Developer", "Publisher", "Genre", "Description", 12, 25, 4, "Registered");
        [TestMethod()]
        public void GameTest()
        {
            Assert.AreEqual(65, thisGame.getGameId());
            Assert.AreEqual("Title", thisGame.getTitle());
            Assert.AreEqual("Developer", thisGame.getDeveloper());
            Assert.AreEqual("Publisher", thisGame.getPublisher());
            Assert.AreEqual("Genre", thisGame.getGenre());
            Assert.AreEqual("Description", thisGame.getDescription());
            Assert.AreEqual(12, thisGame.getBuyPrice());
            Assert.AreEqual(25, thisGame.getSalePrice());
            Assert.AreEqual(4, thisGame.getQuantity());
            Assert.AreEqual("Registered", thisGame.getStatus());
        }

        [TestMethod()]
        public void getGameIdTest()
        {
            Assert.AreEqual(65, thisGame.getGameId());
        }

        [TestMethod()]
        public void setGameIdTest()
        {
            thisGame.setGameId(32);
            Assert.AreEqual(32, thisGame.getGameId());
        }

        [TestMethod()]
        public void getTitleTest()
        {
            Assert.AreEqual("Title", thisGame.getTitle());
        }

        [TestMethod()]
        public void setTitleTest()
        {
            thisGame.setTitle("This");
            Assert.AreEqual("This", thisGame.getTitle());
        }

        [TestMethod()]
        public void getDeveloperTest()
        {
            Assert.AreEqual("Developer", thisGame.getDeveloper());
        }

        [TestMethod()]
        public void setDeveloperTest()
        {
            thisGame.setDeveloper("This");
            Assert.AreEqual("This", thisGame.getDeveloper());
        }

        [TestMethod()]
        public void getPublisherTest()
        {
            Assert.AreEqual("Publisher", thisGame.getPublisher());
        }

        [TestMethod()]
        public void setPublisherTest()
        {
            thisGame.setPublisher("This");
            Assert.AreEqual("This", thisGame.getPublisher());
        }

        [TestMethod()]
        public void getGenreTest()
        {
            Assert.AreEqual("Genre", thisGame.getGenre());
        }

        [TestMethod()]
        public void setGenreTest()
        {
            thisGame.setGenre("Hello");
            Assert.AreEqual("Hello", thisGame.getGenre());
        }

        [TestMethod()]
        public void getDescriptionTest()
        {
            Assert.AreEqual("Description", thisGame.getDescription());
        }

        [TestMethod()]
        public void setDescriptionTest()
        {
            thisGame.setDescription("This");
            Assert.AreEqual("This", thisGame.getDescription());
        }

        [TestMethod()]
        public void getQuantityTest()
        {
            Assert.AreEqual(4, thisGame.getQuantity());
        }

        [TestMethod()]
        public void setQuantityTest()
        {
            thisGame.setQuantity(5);
            Assert.AreEqual(5, thisGame.getQuantity());
        }

        [TestMethod()]
        public void getBuyPriceTest()
        {
            Assert.AreEqual(12, thisGame.getBuyPrice());
        }

        [TestMethod()]
        public void setBuyPriceTest()
        {
            thisGame.setBuyPrice(40);
            Assert.AreEqual(40, thisGame.getBuyPrice());
        }

        [TestMethod()]
        public void getSalePriceTest()
        {
            Assert.AreEqual(25, thisGame.getSalePrice());
        }

        [TestMethod()]
        public void setSalePriceTest()
        {
            thisGame.setSalePrice(70);
            Assert.AreEqual(70, thisGame.getSalePrice());
        }

        [TestMethod()]
        public void getStatusTest()
        {
            Assert.AreEqual("Registered", thisGame.getStatus());
        }

        [TestMethod()]
        public void setStatusTest()
        {
            thisGame.setStatus("This");
            Assert.AreEqual("This", thisGame.getStatus());
        }
    }
}