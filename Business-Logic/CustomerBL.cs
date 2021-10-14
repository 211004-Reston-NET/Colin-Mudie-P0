using System;
using System.Collections.Generic;
using Data_Access_Logic;
using Models;

namespace Business_Logic
{
    public class CustomerBL : ICustomerBL
    {
        private Repository _repo;
        
        public CustomerBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public Customer AddCustomer(Customer p_customer)
        {
            if (p_customer.Name == null || p_customer.Address == null || p_customer.Email == null || p_customer.PhoneNumber == null)
            {
                throw new Exception("You must have a value in all of the properties of the customer class");
            }
            return _repo.AddCustomer(p_customer);
        }

        public List<Customer> GetCustomerList()
        {
            return _repo.GetCustomerList();
        }

        public Orders PlaceOrder(Customer p_customer, Orders P_order)
        {
            return _repo.PlaceOrder(p_customer, P_order);
        }
    }
}
