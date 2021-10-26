using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Entity = Data_Access_Logic.Entities;

namespace Data_Access_Logic
{
    public class RepositoryCloud : IRepository
    {
        private Entity.MMDBContext _context;
        public RepositoryCloud(Entity.MMDBContext p_context)
        {
            _context = p_context;
        }

        public Models.Customer AddCustomer(Models.Customer p_customer)
        {
            throw new NotImplementedException();
        }

        public List<Models.LineItems> ChangeLineItemsQuantity(List<Models.LineItems> p_lineItems, string p_location)
        {
            throw new NotImplementedException();
        }

        public List<Models.Products> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<Models.Customer> GetCustomerList()
        {
            throw new NotImplementedException();
        }

        public List<Models.LineItems> GetLineItemsList(string p_store)
        {
            throw new NotImplementedException();
        }

        public List<Models.StoreFront> GetStoreFrontList()
        {
            throw new NotImplementedException();
        }

        public Models.Orders PlaceOrder(Models.Customer p_customer, Models.Orders p_order)
        {
            throw new NotImplementedException();
        }
    }
}