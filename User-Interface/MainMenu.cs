using System;
namespace User_Interface
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Store Manager \nPlease type the number from the list and press enter \n ");
            Console.WriteLine("[1]: Add Customer" +
                            "\n[2]: Search for Customer" +
                            "\n[3]: View Store Front Inventory" +
                            "\n[4]: Place Order" +
                            "\n[5]: View Order History" +
                            "\n[6]: Replenish Inventory" +
                            "\n[7]: Exit");
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
                    return MenuType.ViewStoreFrontInventory;
                case "4":
                    return MenuType.PlaceOrder;
                case "5": 
                    return MenuType.ViewOrderHistory;
                case "6": 
                    return MenuType.ReplenishInventory;
                case "7": 
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please select one of the options from the list provided. \nPress Enter to Continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}