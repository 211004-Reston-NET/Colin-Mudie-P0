using System;

namespace User_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean stillOn = true;
            
            IMenu page = new MainMenu();

            while (stillOn)
            {
                    // Store Manager ASCII Art
                AscArt();
                page.Menu();
                MenuType currentPage = page.UserChoice();
                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        AscArt();
                        page = new MainMenu();
                        break;

                    case MenuType.AddCustomer:
                        AscArt();
                        ICustomer customer = new AddCustomer();
                        string addCustomerName;
                        string addCustomerAddress;
                        string addCustomerEmail;
                        string addCustomerPhone;
                        Console.WriteLine("   You have selected Add Customer,\n   What is the customer's name?");
                        addCustomerName = customer.Name();
                        addCustomerAddress = customer.Address(addCustomerName);
                        addCustomerEmail = customer.Email(addCustomerName);
                        addCustomerPhone = customer.Phone(addCustomerName);
                        // here we will create a new class of customer from the BL folder with the parameters gathered.
                        Console.WriteLine($"   {addCustomerName} has been added to our list of customers. \n   Please press enter to continue.");
                        Console.ReadLine();
                        break;

                    case MenuType.SearchForCustomer:
                        AscArt();
                        customer = new AddCustomer();
                        string searchCustomerName;
                        string searchCustomerAddress;
                        string searchCustomerEmail;
                        string searchCustomerPhone;
                        Console.WriteLine("   You have selected Search for a Customer, \n   What is the customer's name that you would like to search for?");
                        searchCustomerName = customer.Name();
                        searchCustomerAddress = customer.Address(searchCustomerName);
                        searchCustomerEmail = customer.Email(searchCustomerName);
                        searchCustomerPhone = customer.Phone(searchCustomerName);
                        // search db for this customer, if true give a message you found the customer.
                        // if false give an error message that the customer could not be found.
                        Console.WriteLine($"   We were not able to find {searchCustomerName} as a current customer. " + 
                                            $"\n   Perhaps you would like to add {searchCustomerName} as a customer using the 'Add Customer' feature." + 
                                            "\n   Please press enter to continue.");
                        Console.ReadLine();
                        break;

                    case MenuType.ViewStoreFrontInventory:
                        AscArt();
                        break;

                    case MenuType.PlaceOrder:
                        AscArt();
                        break;

                    case MenuType.ViewOrderHistory:
                        AscArt();
                        break;

                    case MenuType.ReplenishInventory:
                        AscArt();
                        break;

                    case MenuType.Exit:
                        stillOn = false;
                        AscArt();
                        Console.WriteLine("Now Exiting, \nThank you for using the Store Manager!");
                        break;

                    default:
                        AscArt();
                        Console.WriteLine("Please select one of the options from the list provided. \nPress Enter to Continue");
                        Console.ReadLine();
                        break;
                }
            }
            /* 
                UI needs
            - Add Customer (loop questions in case proper validation is not met to reattempt)
                - ask name
                - ask address
                - ask email
                - ask phone number
            - Search for customer
                - input requires name and address to find customer in db.
            - View storefront inventory
                - 
            */

        }
        public static void AscArt(){
            // Store Manager ASCII Art String
            Console.Clear();
            Console.WriteLine("   _____  __                        __  ___                                       " +
            "\n  / ___/ / /_ ____   _____ ___     /  |/  /____ _ ____   ____ _ ____ _ ___   _____" +
            "\n  \\__ \\ / __// __ \\ / ___// _ \\   / /|_/ // __ `// __ \\ / __ `// __ `// _ \\ / ___/" +
            "\n ___/ // /_ / /_/ // /   /  __/  / /  / // /_/ // / / // /_/ // /_/ //  __// /    " +
            "\n/____/ \\__/ \\____//_/    \\___/  /_/  /_/ \\__,_//_/ /_/ \\__,_/ \\__, / \\___//_/     " +
            "\n                                                             /____/                ");
        }
    }
}
