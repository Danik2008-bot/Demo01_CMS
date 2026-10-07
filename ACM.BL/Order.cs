using System;

namespace CMS.BusinessLayer
{
    /// <summary>
    /// Заказ. Данные и проверка; доступ к данным - в OrderRepository.
    /// </summary>
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public int CustomerId { get; set; }
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
