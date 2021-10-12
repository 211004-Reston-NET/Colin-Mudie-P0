using System;
using Models;
using Business_Logic;
using Data_Access_Logic;

namespace User_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean stillOn = true;
            
            IMenu page = new MainMenu();
            Customer currentCustomer = new Customer();
            while (stillOn)
            {
                    // Store Manager ASCII Art
                AscArt();
                if (currentCustomer.Name != null){
                    Console.WriteLine($"                               - Current Customer: {currentCustomer.Name}");
                }
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
                        page = new AddCustomer(new CustomerBL(new Repository()));
                        break;
                    case MenuType.SearchForCustomer:
                        AscArt();
                        break;
                    case MenuType.ViewStoreFrontInventory:
                        AscArt();
                        page = new ShowStoreFronts(new StoreFrontBL(new Repository()));
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
                    case MenuType.ShowCustomers:
                        AscArt();
                        page = new ShowCustomers(new CustomerBL(new Repository()));
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
