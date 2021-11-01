using System;
namespace User_Interface
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("   Welcome to Michigan Modular, " + 
            "\n   We sell Eurorack Modular Synthesizers for the Michigan area." + 
            "\n   Please type the number from the list below and press enter to begin\n "+
            "\n   [1]: Create New Account" +
            "\n   [2]: Login" +
            "\n   [3]: View Store Fronts" +
            "\n   [4]: Search Products by Category" +
            "\n   [5]: Place Order" +
            "\n   [6]: View Order History" +
            "\n   [7]: Replenish Inventory" +
            "\n   [8]: View Products" +
            "\n   [9]: Edit Customer"+
            "\n\n   [0]: Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddCustomer;
                case "2":
                    return MenuType.SearchForCustomer;
                case "3":
                    return MenuType.ShowStoreFronts;
                case "4":
                    return MenuType.SearchByCategory;
                case "5":
                    return MenuType.PlaceOrder;
                case "6": 
                    return MenuType.ViewOrderHistory;
                case "7": 
                    return MenuType.ReplenishInventory;
                case "8":
                    return MenuType.ShowLineItems;
                case "9":
                // used for testing delete before production.
                    return MenuType.CustomerMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("   Please select one of the options from the list provided. "+
                                    "\n   Please press enter to Continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}