using System;
using System.Collections.Generic;
using System.Linq;
using Data_Access_Logic;
using Models;

namespace Business_Logic
{
    public class LineItemsBL : ILineItemsBL
    {
        private Repository _repo;
        public LineItemsBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public List<LineItems> ChangeLineItemsQuantity(LineItems p_lineItems, string p_location)
        {
            List<LineItems> listOfLineItems = _repo.GetLineItemsList(p_location);
            // var lineItemsLINQ = listOfLineItems.FirstOrDefault(item => item.Product.Name == item.Product.Name);
            // lineItemsLINQ.Quantity = p_lineItems.Quantity;
            
            for (int i = 0; i < listOfLineItems.Count; i++)
            {
                if (listOfLineItems[i].Product.Name == p_lineItems.Product.Name)
                {
                    listOfLineItems[i].Quantity = p_lineItems.Quantity;
                }
            }
            _repo.ChangeLineItemsQuantity(listOfLineItems, p_location);

            return listOfLineItems;
        }

        public List<LineItems> GetLineItemsList(string p_location)
        {
            return _repo.GetLineItemsList(p_location);
        }
    }
}