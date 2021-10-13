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
            while (stillOn)
            {
                Console.Clear();
                    // Store Manager ASCII Art
                AscArt();
                if (SingletonCustomer.customer.Name != null){
                    Console.WriteLine($"                               - Current Customer: {SingletonCustomer.customer.Name}");
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
                        page = new SearchCustomers(new CustomerBL(new Repository()));
                        break;
                    case MenuType.ViewStoreFrontInventory:
                        AscArt();
                        page = new ShowStoreFronts(new StoreFrontBL(new Repository()));
                        break;
                    case MenuType.ShowProductsMtP:
                        AscArt();
                        page = new ShowProducts(new ProductsBL(new Repository()), "MtP");
                        break;
                    case MenuType.ShowProductsROak:
                        AscArt();
                        page = new ShowProducts(new ProductsBL(new Repository()), "ROak");
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
            Console.WriteLine("    __  ___ _        __     _                         __  ___            __        __            " +
            "\n   /  |/  /(_)_____ / /_   (_)____ _ ____ _ ____     /  |/  /____   ____/ /__  __ / /____ _ _____" +
            "\n  / /|_/ // // ___// __ \\ / // __ `// __ `// __ \\   / /|_/ // __ \\ / __  // / / // // __ `// ___/" +
            "\n / /  / // // /__ / / / // // /_/ // /_/ // / / /  / /  / // /_/ // /_/ // /_/ // // /_/ // /    " +
            "\n/_/  /_//_/ \\___//_/ /_//_/ \\__, / \\__,_//_/ /_/  /_/  /_/ \\____/ \\__,_/ \\__,_//_/ \\__,_//_/     " +
            "\n                           /____/                                                                ");
        }
    }
}
