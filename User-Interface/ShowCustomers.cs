

using System;
using System.Collections.Generic;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class ShowCustomers : IMenu
    {
        private ICustomerBL _customerBL;
        public ShowCustomers(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Console.WriteLine("Current List of Customers");
            Console.WriteLine("-------------------------");
            List<Customer> listOfCustomers = _customerBL.GetCustomerList();
            foreach (Customer customer in listOfCustomers)
            {
                Console.WriteLine(customer);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("[0] - Go back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}