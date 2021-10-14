using System.Collections.Generic;
using Models;

namespace Business_Logic
{
    public interface ICustomerBL
    {
        /// <summary>
        ///     This will return a list of Customers stored in the database
        /// </summary>
        /// <returns>It will return a list of customers</returns>
        List<Customer> GetCustomerList();

        /// <summary>
        ///     Adds a customer to the database
        /// </summary>
        /// <param name="p_customer"> This is the customer to add</param>
        /// <returns>returns the added customer</returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        ///     This will grab the current list of customers, then grab the current list of Orders for our selected Customer,
        ///     Then it will add our new order to the list and send back to the db.
        /// </summary>
        /// <param name="p_customer"> The customer that will be edited from the List of Customers </param>
        /// <param name="p_order"> The Order that will be added to the list of Orders on our p_customer </param>
        /// <returns> Will return the Order that was placed. </returns>
        Orders PlaceOrder(Customer p_customer, Orders P_order);
    }
}