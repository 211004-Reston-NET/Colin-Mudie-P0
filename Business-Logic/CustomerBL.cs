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
            return _repo.AddCustomer(p_customer);
        }

        public List<Customer> GetCustomerList()
        {
            return _repo.GetCustomerList();
        }
    }
}
