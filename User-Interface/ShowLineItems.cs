using System;
using System.Collections.Generic;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class ShowLineItems : IMenu
    {
        private IProductsBL _lineItems;
        private string _store;
        public ShowLineItems(IProductsBL p_lineItems, string p_store)
        {
            _lineItems = p_lineItems;
            _store = p_store;
        }
        public void Menu()
        {
            Console.WriteLine($"Current List of Products from {SingletonCustomer.location}" + 
                            "\n-------------------------");
            List<LineItems> listOfLineItems = _lineItems.GetLineItemsList(_store);
            foreach (LineItems prod in listOfLineItems)
            {
                Console.WriteLine(prod);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("   [1] - Place an Order" + 
                            "\n   [0] - Go back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {   
                case "1":
                    return MenuType.PlaceOrder;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!" + 
                                    "\nPress Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}