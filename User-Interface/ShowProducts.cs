using System;
using System.Collections.Generic;
using Business_Logic;
using Models;

namespace User_Interface
{
    public class ShowProducts : IMenu
    {
        private IProductsBL _products;
        private string _store;
        public ShowProducts(IProductsBL p_products, string p_store)
        {
            _products = p_products;
            _store = p_store;
        }
        public void Menu()
        {
            Console.WriteLine("Current List of Products");
            Console.WriteLine("-------------------------");
            List<Products> listOfProducts = _products.GetProductsList(_store);
            foreach (Products prod in listOfProducts)
            {
                Console.WriteLine(prod);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("\n   [0] - Go back");
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