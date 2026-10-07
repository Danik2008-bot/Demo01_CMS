using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BusinessLayer;

namespace CMS.BusinessLayerTest
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void CustomerRepositoryRetrieveById()
        {
            //-- Arrange
            var repository = new CustomerRepository();

            //-- Act
            var actual = repository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(1, actual.CustomerId);
        }

        [TestMethod]
        public void CustomerRepositoryRetrieveAll()
        {
            //-- Arrange
            var repository = new CustomerRepository();

            //-- Act
            var actual = repository.Retrieve();

            //-- Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CustomerRepositorySave()
        {
            //-- Arrange
            var repository = new CustomerRepository();
            var customer = new Customer(1) { LastName = "Baggins", EmailAddress = "fbaggins@hobbiton.me" };

            //-- Act
            var actual = repository.Save(customer);

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ProductRepositoryRetrieveById()
        {
            //-- Arrange
            var repository = new ProductRepository();

            //-- Act
            var actual = repository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(2, actual.ProductId);
        }

        [TestMethod]
        public void ProductRepositorySave()
        {
            //-- Arrange
            var repository = new ProductRepository();

            //-- Act
            var actual = repository.Save(new Product(2));

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void OrderRepositoryRetrieveById()
        {
            //-- Arrange
            var repository = new OrderRepository();

            //-- Act
            var actual = repository.Retrieve(3);

            //-- Assert
            Assert.AreEqual(3, actual.OrderId);
        }

        [TestMethod]
        public void OrderRepositorySave()
        {
            //-- Arrange
            var repository = new OrderRepository();

            //-- Act
            var actual = repository.Save(new Order(3));

            //-- Assert
            Assert.AreEqual(true, actual);
        }
    }
}
