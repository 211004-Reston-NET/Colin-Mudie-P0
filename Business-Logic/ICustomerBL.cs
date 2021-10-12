using System.Collections.Generic;
using Models;

namespace Business_Logic
{
    public interface ICustomerBL
    {
        /// <summary>
        /// This will return a list of Customers stored in the database
        /// </summary>
        /// <returns>It will return a list of customers</returns>
        List<Customer> GetCustomerList();
        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="p_customer"> This is the customer to add</param>
        /// <returns>returns the added customer</returns>
        Customer AddCustomer(Customer p_customer);
    }
}