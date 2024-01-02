using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShippingApplication.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        Customer jeff = new Customer(70, "Forename", "Surname", "Tralee", "D12 RE43", "PL!£pl23", "0870000000", "email@email.com", "4321432143214321", "Monaghan", "Registered");
        [TestMethod()]
        public void CustomerTest()
        {
            Assert.AreEqual(70, jeff.getCustomerId());
            Assert.AreEqual("Forename", jeff.getForename());
            Assert.AreEqual("Surname", jeff.getSurname());
            Assert.AreEqual("Tralee", jeff.getTown());
            Assert.AreEqual("D12 RE43", jeff.getEircode());
            Assert.AreEqual("PL!£pl23", jeff.getPassword());
            Assert.AreEqual("0870000000", jeff.getPhoneNumber());
            Assert.AreEqual("email@email.com", jeff.getEmail());
            Assert.AreEqual("4321432143214321", jeff.getCardNumber());
            Assert.AreEqual("Monaghan", jeff.getCounty());
            Assert.AreEqual("Registered", jeff.getStatus());
        }

        [TestMethod()]
        public void getCustomerIdTest()
        {
            Assert.AreEqual(70, jeff.getCustomerId());
        }

        [TestMethod()]
        public void setCustomerIdTest()
        {
            jeff.setCustomerId(73);
            Assert.AreEqual(73, jeff.getCustomerId());
        }

        [TestMethod()]
        public void getSurnameTest()
        {
            Assert.AreEqual("Surname", jeff.getSurname());
        }

        [TestMethod()]
        public void setSurnameTest()
        {
            jeff.setSurname("Stewart");
            Assert.AreEqual("Stewart", jeff.getSurname());
        }

        [TestMethod()]
        public void getForenameTest()
        {
            Assert.AreEqual("Forename", jeff.getForename());
        }

        [TestMethod()]
        public void setForenameTest()
        {
            jeff.setForename("Patrick");
            Assert.AreEqual("Patrick", jeff.getForename());
        }

        [TestMethod()]
        public void getTownTest()
        {
            Assert.AreEqual("Tralee", jeff.getTown());
        }

        [TestMethod()]
        public void setTownTest()
        {
            jeff.setTown("Timbucktoo");
            Assert.AreEqual("Timbucktoo", jeff.getTown());
        }

        [TestMethod()]
        public void getCountyTest()
        {
            Assert.AreEqual("Monaghan", jeff.getCounty());
        }

        [TestMethod()]
        public void setCountyTest()
        {
            jeff.setCounty("Limerick");
            Assert.AreEqual("Limerick", jeff.getCounty());
        }

        [TestMethod()]
        public void getEircodeTest()
        {
            Assert.AreEqual("D12 RE43", jeff.getEircode());
        }

        [TestMethod()]
        public void setEircodeTest()
        {
            jeff.setEircode("V43 EG65");
            Assert.AreEqual("V43 EG65", jeff.getEircode());
        }

        [TestMethod()]
        public void getPasswordTest()
        {
            Assert.AreEqual("PL!£pl23", jeff.getPassword());
        }

        [TestMethod()]
        public void setPasswordTest()
        {
            jeff.setPassword("PL!£pl23");
            Assert.AreEqual("PL!£pl23", jeff.getPassword());
        }

        [TestMethod()]
        public void getPhoneNumberTest()
        {
            Assert.AreEqual("0870000000", jeff.getPhoneNumber());
        }

        [TestMethod()]
        public void setPhoneNumberTest()
        {
            jeff.setPhoneNumber("0868901314");
            Assert.AreEqual("0868901314", jeff.getPhoneNumber());
        }

        [TestMethod()]
        public void getEmailTest()
        {
            Assert.AreEqual("email@email.com", jeff.getEmail());
        }

        [TestMethod()]
        public void setEmailTest()
        {
            jeff.setEmail("thisEmail@gmail.com");
            Assert.AreEqual("thisEmail@gmail.com", jeff.getEmail());
        }

        [TestMethod()]
        public void getCardNumberTest()
        {
            Assert.AreEqual("4321432143214321", jeff.getCardNumber());
        }

        [TestMethod()]
        public void setCardNumberTest()
        {
            jeff.setCardNumber("0987098709870987");
            Assert.AreEqual("0987098709870987", jeff.getCardNumber());
        }

        [TestMethod()]
        public void getStatusTest()
        {
            Assert.AreEqual("Registered", jeff.getStatus());
        }

        [TestMethod()]
        public void setStatusTest()
        {
            jeff.setStatus("Deregistered");
            Assert.AreEqual("Deregistered", jeff.getStatus());
        }

        [TestMethod()]
        public void isValidCardNumberTest()
        {
            Assert.AreEqual(true, Customer.isValidCardNumber(jeff.getCardNumber()));
        }

        [TestMethod()]
        public void isValidEircodeTest()
        {
            Assert.AreEqual(true, Customer.isValidEircode(jeff.getEircode()));
        }

        [TestMethod()]
        public void isValidPasswordTest()
        {
            Assert.AreEqual(true, Customer.isValidPassword(jeff.getPassword()));
        }

        [TestMethod()]
        public void isValidEmailTest()
        {
            Assert.AreEqual(true, Customer.isValidEmail(jeff.getEmail()));
        }

        [TestMethod()]
        public void isValidPhoneTest()
        {
            Assert.AreEqual(true, Customer.isValidPhone(jeff.getPhoneNumber()));
        }
    }
}