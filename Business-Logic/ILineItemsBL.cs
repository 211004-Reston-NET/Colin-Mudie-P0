using System.Collections.Generic;
using Models;

namespace Business_Logic
{
    public interface ILineItemsBL
    {
        /// <summary>
        /// This will return a list of Products stored in the db.
        /// </summary>
        /// <param name="p_storeId"> the parameter passed in will be the stores ID, in order to determine which product list to use.</param>
        /// <returns>It will return a list of Products.</returns>
        List<LineItems> GetLineItems(int p_storeId);

        // /// <summary>
        // /// Gets all lineItems from the correct store location, then checks it for the LineItem p_lineItem and updates the listofLineItems.
        // /// </summary>
        // /// <param name="p_listOfLineItems"> new product which needs to be updated </param>
        // /// <param name="p_location"> location for the LineItems list to be updated. </param>
        // /// <returns> returns the updated list of LineItems. </returns>
        // List<LineItems> ChangeLineItemsQuantity(LineItems p_lineItem, string p_location);
    }
}