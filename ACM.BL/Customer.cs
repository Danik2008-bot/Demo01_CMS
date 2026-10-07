using System;

namespace CMS.BusinessLayer
{
    /// <summary>
    /// Клиент. Отвечает только за свои данные и их проверку.
    /// Доступ к данным (Retrieve/Save) вынесен в CustomerRepository.
    /// </summary>
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                // Any code here
                return _lastName;
            }
            set
            {
                // Any code here
                _lastName = value;
            }
        }

        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }

        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
