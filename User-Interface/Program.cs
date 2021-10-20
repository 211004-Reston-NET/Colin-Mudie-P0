using System;
using Models;
using Business_Logic;
using Data_Access_Logic;
using System.Globalization;

namespace User_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stillOn = true;
            IMenu page = new StartMenu();
            while (stillOn)
            {
                    // Store Manager ASCII Art
                AscArt();
                if (SingletonCustomer.customer.Name != null)
                {
                    TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                    Console.WriteLine($"                               - Current Customer: {myTI.ToTitleCase(SingletonCustomer.customer.Name)}");
                }
                if (SingletonCustomer.location != null)
                {
                    Console.WriteLine($"                               - Current Store Location: {SingletonCustomer.location}");
                }
                page.Menu();
                MenuType currentPage = page.UserChoice();
                switch (currentPage)
                {
                    case MenuType.StartMenu:
                        page = new StartMenu();
                        break;

                    case MenuType.MainMenu:
                        page = new MainMenu();
                        break;

                    case MenuType.AddCustomer:                        
                        page = new AddCustomer(new CustomerBL(new Repository()));
                        break;

                    case MenuType.SearchForCustomer:
                        page = new SearchCustomers(new CustomerBL(new Repository()));
                        break;

                    case MenuType.ShowStoreFronts:
                        page = new ShowStoreFronts(new StoreFrontBL(new Repository()));
                        break;

                    case MenuType.ShowProductsMtP:
                        page = new ShowLineItems(new LineItemsBL(new Repository()), "Mt Pleasant");
                        break;

                    case MenuType.ShowProductsROak:
                        page = new ShowLineItems(new LineItemsBL(new Repository()), "Royal Oak");
                        break;

                    case MenuType.SearchByCategory:
                        page = new SearchByCategory(new ProductBL(new Repository()));
                        break;
                        
                    case MenuType.PlaceOrder:
                        page = new PlaceOrder(new CustomerBL(new Repository()), new LineItemsBL(new Repository()), SingletonCustomer.location);
                        break;

                    case MenuType.ViewOrderHistory:
                        break;

                    case MenuType.ReplenishInventory:
                        break;
                        
                    case MenuType.ShowCustomers:
                        page = new ShowCustomers(new CustomerBL(new Repository()));
                        break;

                    case MenuType.Exit:
                        stillOn = false;
                        AscArt();
                        Console.WriteLine("Now Exiting,"+
                                        "\n   Thank you for using the Store Manager!");
                        break;

                    default:
                        AscArt();
                        Console.WriteLine("Please select one of the options from the list provided. "+
                                        "\n   Please press enter to Continue");
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
