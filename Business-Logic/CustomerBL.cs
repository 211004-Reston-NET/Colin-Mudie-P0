﻿using System;
using System.Collections.Generic;
using System.Linq;
using Data_Access_Logic;
using Models;

namespace Business_Logic
{
    public class CustomerBL : ICustomerBL
    {
        private IRepository _repo;
        
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customer AddCustomer(Customer p_customer)
        {
            //|| p_customer.Address == null || p_customer.Email == null || p_customer.PhoneNumber == null
            // finish exceptions for address, email and phone.
            if (p_customer.Name == null )
            {
                throw new Exception("You must input customer name.");
            }
            return _repo.AddCustomer(p_customer);
        }

        public List<Customer> GetCustomerList()
        {
            return _repo.GetCustomerList();
        }

        public Customer GetSingleCustomer(string p_name, string p_email)
        {
            List<Customer> listOfCustomers = _repo.GetCustomerList();
            return listOfCustomers.FirstOrDefault(cust => cust.Name == p_name && cust.Email == p_email);
        }

        public Orders PlaceOrder(Customer p_customer, Orders P_order)
        {   
            Console.WriteLine(P_order);
            return _repo.PlaceOrder(p_customer, P_order);
        }
    }
}
