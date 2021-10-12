using System;
using System.Collections.Generic;

namespace Models
{
    public class StoreFront
    // The store front contains information pertaining the various store locations
    {
        private string _name;
        private string _address;
        private List<Products> _products;
        private List<Orders> _orders;

        //properties
        public string Name { 
            get
            {
                return _name;
            }
            set
            { 
                _name = value;
            } 
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public List<Products> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
            }
        }
        public List<Orders> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} \nAddress: {Address} \nProducts: {Products} \nOrders: {Orders}";
        }
    }
}