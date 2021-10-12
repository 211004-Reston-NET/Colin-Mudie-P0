using System;
namespace User_Interface
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("   Welcome to the Store Manager \n   Please type the number from the list and press enter \n ");
            Console.WriteLine("   [1]: Add Customer" +
                            "\n   [2]: Search for Customer" +
                            "\n   [3]: Show all Customers" +
                            "\n   [4]: View Store Fronts" +
                            "\n   [5]: Place Order" +
                            "\n   [6]: View Order History" +
                            "\n   [7]: Replenish Inventory" +
                            "\n   [8]: Exit");
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
                    return MenuType.ShowCustomers;
                case "4":
                    return MenuType.ViewStoreFrontInventory;
                case "5":
                    return MenuType.PlaceOrder;
                case "6": 
                    return MenuType.ViewOrderHistory;
                case "7": 
                    return MenuType.ReplenishInventory;
                case "8": 
                    return MenuType.Exit;
                default:
                    Console.WriteLine("   Please select one of the options from the list provided. \n   Press Enter to Continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}