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
            Console.WriteLine("Michigan Modular Locations");
            Console.WriteLine("-------------------------");
            List<StoreFront> listOfStores = _storeFront.GetStoreFrontList();
            for (var i = 0; i < listOfStores.Count; i++)
            {
                Console.WriteLine(i + 1);
                Console.WriteLine(listOfStores[i]);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("   [1] - Michigan Modular Mt Pleasant");
            Console.WriteLine("   [2] - Michigan Modular Royal Oak");
            Console.WriteLine("\n   [0] - Go back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "1":
                    return MenuType.ShowProductsMtP;
                case "2":
                    return MenuType.ShowProductsROak;
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