using System;
using System.Collections.Generic;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class PlaceOrder : IMenu
    {
        private static bool _loaded = false;
        private ILineItemsBL _lineItems;
        private string _store;
        private ICustomerBL _customerBL;
        public PlaceOrder(ICustomerBL p_customerBL, ILineItemsBL p_lineItems, string p_store)
        {
            _customerBL = p_customerBL;
            _lineItems = p_lineItems;
            _store = p_store;
        }
        public void Menu()
        {
        
                List<LineItems> listOfLineItems = _lineItems.GetLineItemsList(_store);
            
            
            Console.WriteLine($"Current List of Products from {SingletonCustomer.location}");
            
            foreach (LineItems prod in listOfLineItems)
            {
                Console.WriteLine("-------------------------" +
                                $" \nBrand: {prod.Product.Brand}" +
                                $" \nName: {prod.Product.Name}" +
                                $" \nPrice: {prod.Product.Price}" +
                                $" \nStock Left: {prod.Quantity}");
            }
            Console.WriteLine("\n_________________________" +
                            "\n      Shopping Cart" +
                            "\n-------------------------");
            if (SingletonCustomer.orders.LineItems.Count == 0)
            {
                Console.WriteLine("          empty" +
                                "\n-------------------------");
            }
            foreach (LineItems item in SingletonCustomer.orders.LineItems)
            {
                Console.WriteLine($"   {item.Product.Name} " +
                                $" \n   Quantity: {item.Quantity} " +
                                $" \n   Price: {item.Product.Price}" +
                                "\n-------------------------");
            }
            Console.WriteLine($"Store Location: {SingletonCustomer.location}" +
                            $" \nTotal Price: {SingletonCustomer.orders.TotalPrice}" +
                            "\n-------------------------" +
                            "\n   [1] - Add Product to Shopping Cart" +
                            "\n   [2] - Complete Order" +
                            "\n\n   [0] - Main Menu");
        }

        public MenuType UserChoice()
        {
            List<LineItems> listOfLineItems = _lineItems.GetLineItemsList(_store);
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("   Please Type the name of the product you would like to add.");
                    string _inputName = Console.ReadLine().Trim().ToLower();
                
                    foreach (LineItems prod in listOfLineItems)
                    {
                        Console.WriteLine(prod);
                        if (_inputName == prod.Product.Name.ToLower())
                        {
                            Console.WriteLine($"   How many {_inputName} module's would you like to add?");
                            int _inputQuantity = int.Parse(Console.ReadLine().Trim());
                            LineItems tempProduct = prod;
                            _lineItems.ChangeLineItemsQuantity(tempProduct, _store);

                            prod.Quantity =_inputQuantity;
                            SingletonCustomer.orders.LineItems.Add(prod);
                            SingletonCustomer.orders.TotalPrice = SingletonCustomer.orders.TotalPrice + (_inputQuantity * prod.Product.Price);
                            if (_inputQuantity <= 0)
                            {
                                Console.WriteLine($"   You must enter a quantity higher than 0" +
                                                "\n   Press Enter to continue");
                                Console.ReadLine();
                                return MenuType.PlaceOrder;
                            }
                            else if (_inputQuantity == 1)
                            {

                                Console.WriteLine($"   {_inputQuantity} {_inputName} module has been added to the Shopping Cart" +
                                                "\n   Press Enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"   {_inputQuantity} {_inputName} module's have been added to the Shopping Cart" +
                                                "\n   Press Enter to continue");
                                Console.ReadLine();
                            }
                        }
                    }

                    return MenuType.PlaceOrder;
                case "2":
                    //--------- add Order to DB here.---------\\
                    _customerBL.PlaceOrder(SingletonCustomer.customer, SingletonCustomer.orders);
                    Console.WriteLine("   Order Placed" +
                                    "\n   Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("   Please input a valid response!" +
                                    "\n   Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.PlaceOrder;
            }
        }
    }
}