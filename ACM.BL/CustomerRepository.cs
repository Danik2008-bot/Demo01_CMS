using System.Collections.Generic;

namespace CMS.BusinessLayer
{
    /// <summary>
    /// Уровень доступа к данным для Customer.
    /// </summary>
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the defined customer
            return new Customer(customerId);
        }

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        public List<Customer> Retrieve()
        {
            // Code that retrieves all customers
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        public bool Save(Customer customer)
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
