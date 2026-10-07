using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BusinessLayer;

namespace CMS.BusinessLayerTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var order = new Order();
            order.OrderDate = new DateTimeOffset(2026, 10, 7, 0, 0, 0, TimeSpan.Zero);

            //-- Act
            var actual = order.Validate();

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateMissingDate()
        {
            //-- Arrange
            var order = new Order();

            //-- Act
            var actual = order.Validate();

            //-- Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ShippingAddressIsSeparateObject()
        {
            //-- Arrange
            var order = new Order();
            order.ShippingAddress = new Address { City = "Hobbiton" };

            //-- Assert
            Assert.AreEqual("Hobbiton", order.ShippingAddress.City);
        }
    }
}
