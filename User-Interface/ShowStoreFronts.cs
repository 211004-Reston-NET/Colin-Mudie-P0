

using System;
using System.Collections.Generic;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class ShowStoreFronts : IMenu
    {
        private IStoreFrontBL _storeFront;
        public ShowStoreFronts(IStoreFrontBL p_storeFront)
        {
            _storeFront = p_storeFront;
        }
        public void Menu()
        {
            Console.WriteLine("Current List of Customers");
            Console.WriteLine("-------------------------");
            List<StoreFront> listOfStores = _storeFront.GetStoreFrontList();
            foreach (StoreFront store in listOfStores)
            {
                Console.WriteLine(store);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("[0] - Go back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}