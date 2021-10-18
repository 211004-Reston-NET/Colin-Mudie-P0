

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
            Console.WriteLine("Customer Search" +
                            "\n-------------------------" +
                            "\nName - " + SingletonCustomer.customer.Name +
                            "\nAddress - " + SingletonCustomer.customer.Address +
                            "\nEmail - " + SingletonCustomer.customer.Email +
                            "\nPhone - " + SingletonCustomer.customer.PhoneNumber +
                            "\n-------------------------" +
                            "\n   [1] - Edit Name" +
                            "\n   [2] - Edit Address" +
                            "\n   [3] - Edit Email" +
                            "\n   [4] - Edit Phone Number" +
                            "\n   [5] - Login" +
                            "\n\n   [0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Type in the new value for the Name");
                    SingletonCustomer.customer.Name = Console.ReadLine();
                    return MenuType.SearchForCustomer;

                case "2":
                    Console.WriteLine("Type in the new value for the Address");
                    SingletonCustomer.customer.Address = Console.ReadLine();
                    return MenuType.SearchForCustomer;

                case "3":
                    Console.WriteLine("Type in the new value for the Email");
                    SingletonCustomer.customer.Email = Console.ReadLine();
                    return MenuType.SearchForCustomer;

                case "4":
                    Console.WriteLine("Type in the new value for Phone Number");
                    SingletonCustomer.customer.PhoneNumber = Console.ReadLine();
                    return MenuType.SearchForCustomer;

                case "5":
                    List<Customer> listOfCustomers = _customerBL.GetCustomerList();
                    foreach (Customer customer in listOfCustomers)
                    {
                        if (customer.Name == SingletonCustomer.customer.Name && customer.Address == SingletonCustomer.customer.Address && customer.Email == SingletonCustomer.customer.Email && customer.PhoneNumber == SingletonCustomer.customer.PhoneNumber)
                        {
                            // do something to make that person "logged in"
                            Console.WriteLine($"{SingletonCustomer.customer.Name} was found in the list of customers"+
                                            "\n   Please press enter to continue.");
                            Console.ReadLine();
                            return MenuType.MainMenu;
                        }
                    }
                    Console.WriteLine($"We couldn't find {SingletonCustomer.customer.Name}, please double check you have the correct information." +
                                    "\n   Please press enter to continue.");
                    Console.ReadLine();
                    return MenuType.SearchForCustomer;

                case "0":
                    return MenuType.StartMenu;

                default:
                    Console.WriteLine("Please input a valid response!" +
                                    "\n   Pleas press enter to continue");
                    Console.ReadLine();
                    return MenuType.SearchForCustomer;
            }
        }
    }
}