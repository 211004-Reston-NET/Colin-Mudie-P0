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
        ///     This will return a list of Store Fronts from the db.
        /// </summary>
        /// <returns> will return a list of StoreFronts.</returns>
        List<StoreFront> GetStoreFrontList();

        /// <summary>
        ///     This will return a list of products from the db.
        /// </summary>
        /// <param name="p_storeId"> The ID of the store to retrieve the Line Items from. </param>
        /// <returns> will return a list of products. </returns>
        List<LineItems> GetLineItemsList(int p_storeId);

        /// <summary>
        ///     This will grab the current list of customers, then grab the current list of Orders for our selected Customer,
        ///     Then it will add our new order to the list and send back to the db.
        /// </summary>
        /// <param name="p_customer"> The customer that will be edited from the List of Customers </param>
        /// <param name="p_order"> The Order that will be added to the list of Orders on our p_customer </param>
        /// <returns> Will return the Order that was placed. </returns>
        Orders PlaceOrder(Customer p_customer, Orders p_order);

        /// <summary>
        ///     This will grab the current list of products from db.
        /// </summary>
        /// <returns> Will return a list of products </returns>
        List<Products> GetAllProducts();

        /// <summary>
        ///     This will return 1 product and will require the products product_id.
        /// </summary>
        /// <param name="p_productId"> the product_id that will match in the database </param>
        /// <returns> returns a single Products class </returns>
        Products GetProductByProductId(int p_productId);
    }
}