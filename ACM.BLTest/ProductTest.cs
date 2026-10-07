using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BusinessLayer;

namespace CMS.BusinessLayerTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var product = new Product();
            product.ProductName = "Sunflowers";
            product.CurrentPrice = 15.96M;

            //-- Act
            var actual = product.Validate();

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateMissingName()
        {
            //-- Arrange
            var product = new Product();
            product.CurrentPrice = 15.96M;

            //-- Act
            var actual = product.Validate();

            //-- Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateMissingPrice()
        {
            //-- Arrange
            var product = new Product();
            product.ProductName = "Sunflowers";

            //-- Act
            var actual = product.Validate();

            //-- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
