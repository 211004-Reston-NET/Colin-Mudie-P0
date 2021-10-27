using System;
using System.Collections.Generic;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class ShowLineItems : IMenu
    {
        private ILineItemsBL _lineItems;
        public ShowLineItems(ILineItemsBL p_lineItems)
        {
            _lineItems = p_lineItems;
        }
        public void Menu()
        {
            Console.WriteLine($"Current List of Products from {SingletonCustomer.location}" + 
                            "\n-------------------------");
            List<LineItems> listOfLineItems = _lineItems.GetLineItems(SingletonCustomer.orders.StoreFrontId);
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
                    return MenuType.ShowStoreFronts;
                default:
                    Console.WriteLine("Please input a valid response!" + 
                                    "\nPress Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}

