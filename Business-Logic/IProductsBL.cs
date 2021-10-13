using System.Collections.Generic;
using Models;

namespace Business_Logic
{
    public interface IProductsBL
    {
        /// <summary>
        /// This will return a list of Products stored in the db.
        /// </summary>
        /// <param name="p_store"> the parameter passed in will be the stores location, in order to determine which product list to use.</param>
        /// <returns>It will return a list of Products.</returns>
        List<Products> GetProductsList(string p_store);
    }
}