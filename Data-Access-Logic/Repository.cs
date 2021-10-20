using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace Data_Access_Logic
{
    public class Repository : IRepository
    {
        private const string _filepath = "./../Data-Access-Logic/Database/";
        private string _jsonString;
        public Customer AddCustomer(Customer p_customer)
        {
            List<Customer> listOfCustomers = GetCustomerList();
            listOfCustomers.Add(p_customer);
            _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions{WriteIndented = true});

            File.WriteAllText(_filepath+"Customer.json", _jsonString);
            return p_customer;
        }

        public List<Products> GetAllProducts()
        {
            _jsonString = File.ReadAllText(_filepath+"Products.json");
            return JsonSerializer.Deserialize<List<Products>>(_jsonString);
        }

        public List<Customer> GetCustomerList()
        {
            _jsonString = File.ReadAllText(_filepath+"Customer.json");
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public List<LineItems> GetLineItemsList(string p_store)
        {
            switch (p_store)
            {
                case "Royal Oak":
                    _jsonString = File.ReadAllText(_filepath+"RoyalOakProducts.json");
                    break;
                case "Mt Pleasant":
                    _jsonString = File.ReadAllText(_filepath+"MtPleasantProducts.json");
                    break;
                default:
                    _jsonString = File.ReadAllText(_filepath+"MtPleasantProducts.json");
                break;
            }
            
            return JsonSerializer.Deserialize<List<LineItems>>(_jsonString);
        }

        public List<StoreFront> GetStoreFrontList()
        {
            _jsonString = File.ReadAllText(_filepath+"StoreFront.json");
            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }

        public Orders PlaceOrder(Customer p_customer, Orders p_order)
        {
            List<Customer> listOfCustomers = GetCustomerList();
            foreach (Customer customer in listOfCustomers)
            {
                if (customer.Name == p_customer.Name && 
                    customer.Address == p_customer.Address && 
                    customer.Email == p_customer.Email && 
                    customer.PhoneNumber == p_customer.PhoneNumber)
                {
                    customer.Orders.Add(p_order);
                    _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(_filepath + "Customer.json", _jsonString);
                }
            }
            return p_order;
        }
    }
}
