using System.Collections.Generic;
using Models;

namespace Business_Logic
{
    public interface IProductsBL
    {
        /// <summary>
        /// This will return a list of Products stored in the db.
        /// </summary>
        /// <returns>It will return a list of Products.</returns>
        List<Products> GetProductsList();
    }
}