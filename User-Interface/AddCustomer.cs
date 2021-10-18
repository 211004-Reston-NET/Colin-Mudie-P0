using System;
using Business_Logic;

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
            Console.WriteLine("Creating a new Account"+
                            "\n-------------------------"+
                            $" \nName - {SingletonCustomer.customer.Name}"+
                            $" \nAddress - {SingletonCustomer.customer.Address}"+
                            $" \nEmail - {SingletonCustomer.customer.Email}"+
                            $" \nPhone - {SingletonCustomer.customer.PhoneNumber}"+
                            "  \n-------------------------"+
                            "\n   [1] - Edit Name"+
                            "\n   [2] - Edit Address"+
                            "\n   [3] - Edit Email"+
                            "\n   [4] - Edit Phone Number"+
                            "\n   [5] - Save Account Details"+
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
                    return MenuType.AddCustomer;

                case "2":
                    Console.WriteLine("Type in the new value for the Address");
                    SingletonCustomer.customer.Address = Console.ReadLine();
                    return MenuType.AddCustomer;

                case "3":
                    Console.WriteLine("Type in the new value for the Email");
                    SingletonCustomer.customer.Email = Console.ReadLine();
                    return MenuType.AddCustomer;

                case "4":
                    Console.WriteLine("Type in the new value for Phone Number");
                    SingletonCustomer.customer.PhoneNumber = Console.ReadLine();
                    return MenuType.AddCustomer;

                case "5":
                    try
                    {
                        _customerBL.AddCustomer(SingletonCustomer.customer);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above"+
                                        "\nPress Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddCustomer;
                    }
                    Console.WriteLine($"{SingletonCustomer.customer.Name} has been added to our list of customers. \n   Please press enter to continue.");
                    Console.ReadLine();
                    return MenuType.MainMenu;

                case "0":
                    return MenuType.StartMenu;

                default:
                    Console.WriteLine("Please input a valid response!"+
                                    "\nPress Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
            }
        }
    }
}