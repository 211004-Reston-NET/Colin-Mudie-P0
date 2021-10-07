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
                        page = new AddCustomer();
                        string addCustomerName = Console.ReadLine();
                        Console.WriteLine($"What is {addCustomerName}'s address?");
                        string addCustomerAddress = Console.ReadLine();
                        Console.WriteLine($"What is {addCustomerName}'s email address?");
                        string addCustomerEmail = Console.ReadLine();
                        Console.WriteLine($"What is {addCustomerName}'s phone number?");
                        string addCustomerPhone = Console.ReadLine();
                        Console.WriteLine($"{addCustomerName} has been added to our list of customers. \n   Please press enter to continue.");
                        Console.ReadLine();
                        break;
                    case MenuType.SearchForCustomer:
                        AscArt();
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
