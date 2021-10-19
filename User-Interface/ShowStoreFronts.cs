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
            Console.WriteLine("Michigan Modular Locations" + 
                            "\n-------------------------");
            List<StoreFront> listOfStores = _storeFront.GetStoreFrontList();
            for (var i = 0; i < listOfStores.Count; i++)
            {
                Console.WriteLine($"{i + 1}"+
                                $" \n{listOfStores[i]}"+
                                "\n-------------------------");
            }
            Console.WriteLine("Please Select a Store to view."+
                            "\n   [1] - Michigan Modular Mt Pleasant"+
                            "\n   [2] - Michigan Modular Royal Oak"+
                            "\n   [0] - Go back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "1":
                    SingletonCustomer.location = "Mt Pleasant";
                    SingletonCustomer.orders.Address = "5240 Mission St, Mt Pleasant, MI 48858";
                    return MenuType.ShowProductsMtP;
                case "2":
                    SingletonCustomer.location = "Royal Oak";
                    SingletonCustomer.orders.Address = "332 Leafdale Blvd, Royal Oak, MI 48073";
                    return MenuType.ShowProductsROak;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!"+
                                    "\nPress Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}