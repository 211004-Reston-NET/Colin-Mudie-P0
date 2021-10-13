

using System;
using System.Collections.Generic;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class SearchCustomers : IMenu
    {
        // private static Customer _customer = new Customer();
        
        private ICustomerBL _customerBL;
        public SearchCustomers(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Console.WriteLine("Customer Search");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Name - " + SingletonCustomer.customer.Name);
            Console.WriteLine("Address - " + SingletonCustomer.customer.Address);
            Console.WriteLine("Email - " + SingletonCustomer.customer.Email);
            Console.WriteLine("Phone - " + SingletonCustomer.customer.PhoneNumber);
            Console.WriteLine("-------------------------");
            Console.WriteLine("[5] - Search Customer");
            Console.WriteLine("[4] - Edit Name");
            Console.WriteLine("[3] - Edit Address");
            Console.WriteLine("[2] - Edit Email");
            Console.WriteLine("[1] - Edit Phone Number");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                    //Add implementation to talk to the repository method to add a restaurant
                    List<Customer> listOfCustomers = _customerBL.GetCustomerList();
                    foreach (Customer customer in listOfCustomers)
                    {
                        if (customer.Name == SingletonCustomer.customer.Name && customer.Address == SingletonCustomer.customer.Address && customer.Email == SingletonCustomer.customer.Email && customer.PhoneNumber == SingletonCustomer.customer.PhoneNumber){
                            Console.WriteLine($"{SingletonCustomer.customer.Name} was found in the list of customers");
            // do something to make that person "logged in"
                            Console.WriteLine($"   Please press enter to continue.");
                            Console.ReadLine();
                            return MenuType.MainMenu;
                        } else {
                            Console.WriteLine($"We couldn't find {SingletonCustomer.customer.Name}, please double check you have the correct information.");
                            Console.WriteLine($"   Please press enter to continue.");
                            Console.ReadLine();
                            return MenuType.SearchForCustomer;
                        }
                    }
                    return MenuType.MainMenu;
                case "4":
                    Console.WriteLine("Type in the new value for the Name");
                    SingletonCustomer.customer.Name = Console.ReadLine();
                    return MenuType.SearchForCustomer;
                case "3":
                    Console.WriteLine("Type in the new value for the Address");
                    SingletonCustomer.customer.Address = Console.ReadLine();
                    return MenuType.SearchForCustomer;
                case "2":
                    Console.WriteLine("Type in the new value for the Email");
                    SingletonCustomer.customer.Email = Console.ReadLine();
                    return MenuType.SearchForCustomer;
                case "1":
                    Console.WriteLine("Type in the new value for Phone Number");
                    SingletonCustomer.customer.PhoneNumber = Console.ReadLine();
                    return MenuType.SearchForCustomer;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.SearchForCustomer;
            }
        }
    }
}