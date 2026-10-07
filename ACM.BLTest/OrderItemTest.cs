using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BusinessLayer;

namespace CMS.BusinessLayerTest
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var item = new OrderItem();
            item.OrderQuantity = 2;
            item.ProductId = 1;
            item.PurchasePrice = 10M;

            //-- Act
            var actual = item.Validate();

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateMissingQuantity()
        {
            //-- Arrange
            var item = new OrderItem();
            item.ProductId = 1;
            item.PurchasePrice = 10M;

            //-- Act
            var actual = item.Validate();

            //-- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
