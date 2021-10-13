using System;
using System.Text.RegularExpressions;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class AddCustomer : IMenu
    {
        // private static Customer _customer = new Customer();
        private ICustomerBL _customerBL;
        public AddCustomer(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Console.WriteLine("Adding a new Customer");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Name - " + SingletonCustomer.customer.Name);
            Console.WriteLine("Address - " + SingletonCustomer.customer.Address);
            Console.WriteLine("Email - " + SingletonCustomer.customer.Email);
            Console.WriteLine("Phone - " + SingletonCustomer.customer.PhoneNumber);
            Console.WriteLine("-------------------------");
            Console.WriteLine("[5] - Save Customer");
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
                    _customerBL.AddCustomer(SingletonCustomer.customer);
                    Console.WriteLine($"{SingletonCustomer.customer.Name} has been added to our list of customers. \n   Please press enter to continue.");
                    Console.ReadLine();
                    return MenuType.MainMenu;
                case "4":
                    Console.WriteLine("Type in the new value for the Name");
                    SingletonCustomer.customer.Name = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "3":
                    Console.WriteLine("Type in the new value for the Address");
                    SingletonCustomer.customer.Address = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "2":
                    Console.WriteLine("Type in the new value for the Email");
                    SingletonCustomer.customer.Email = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the new value for Phone Number");
                    SingletonCustomer.customer.PhoneNumber = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
            }
        }
    }
}