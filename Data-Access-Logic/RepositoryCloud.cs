using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            _context.Customers.Add(
                new Entity.Customer()
                {
                    Name = p_customer.Name,
                    Email = p_customer.Email,
                    PhoneNumber = p_customer.PhoneNumber,
                    Address = p_customer.Address
                }
            );
            _context.SaveChanges();
            return p_customer;
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
            return _context.Customers.Select(cust => 
            new Models.Customer()
            {
                Name = cust.Name,
                Email = cust.Email,
                Address = cust.Address,
                PhoneNumber = cust.PhoneNumber,
                CustomerId = cust.CustomerId
            }
            ).ToList();
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