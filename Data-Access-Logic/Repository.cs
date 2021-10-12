using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace Data_Access_Logic
{
    public class Repository : IRepository
    {
        private const string _customerFilepath = "./../Data-Access-Logic/Database/Customer.json";
        private const string _storefrontFilePath = "./../Data-Access-Logic/Database/Storefront.json";
        private const string _productsFilepath = "./../Data-Access-Logic/Database/Products.json";
        private string _jsonString;
        public Customer AddCustomer(Customer p_customer)
        {
            List<Customer> listOfCustomers = GetCustomerList();
            listOfCustomers.Add(p_customer);
            _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions{WriteIndented = true});

            File.WriteAllText(_customerFilepath, _jsonString);
            return p_customer;
        }

        public List<Customer> GetCustomerList()
        {
            _jsonString = File.ReadAllText(_customerFilepath);
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public List<Products> GetProductsList()
        {
            _jsonString = File.ReadAllText(_productsFilepath);
            return JsonSerializer.Deserialize<List<Products>>(_jsonString);
        }

        public List<StoreFront> GetStoreFrontList()
        {
            _jsonString = File.ReadAllText(_storefrontFilePath);
            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }
    }
}
