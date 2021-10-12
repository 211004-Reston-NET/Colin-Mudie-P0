using System.Collections.Generic;
using Models;
namespace Data_Access_Logic
{
    public interface IRepository
    {
        /// <summary>
        /// adds a customer to our database.
        /// </summary>
        /// <param name="p_customer"> this is the Customer class that will be added to the db </param>
        /// <returns> will return the </returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// This will return a list of Customers stored in the database
        /// </summary>
        /// <returns> will return a list of Customers</returns>
        List<Customer> GetCustomerList();
        
        /// <summary>
        /// This will return a list of Store Fronts from the db.
        /// </summary>
        /// <returns> will return a list of StoreFronts.</returns>
        List<StoreFront> GetStoreFrontList();

        /// <summary>
        /// This will return a list of products from the db.
        /// </summary>
        /// <returns> will return a list of products. </returns>
        List<Products> GetProductsList();
    }
}