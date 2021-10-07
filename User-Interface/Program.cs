﻿using System;

namespace User_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean stillOn = true;
            

            while (stillOn)
            {
                    // Store Manager ASCII Art
                AscArt();
                Console.WriteLine("Welcome to the Store Manager \nPlease type the number from the list and press enter \n ");
                Console.WriteLine("[1]: Add Customer" +
                                "\n[2]: Search for Customer" +
                                "\n[3]: View Store Front Inventory" +
                                "\n[4]: Place Order" +
                                "\n[5]: View Order History" +
                                "\n[6]: Replenish Inventory" +
                                "\n[7]: Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //add user
                        AscArt();
                            Console.WriteLine("You have selected Add Customer, \n what is the customer's name?");
                            string addCustomerName = Console.ReadLine();
                            Console.WriteLine($"What is {addCustomerName}'s address?");
                            string addCustomerAddress = Console.ReadLine();
                            Console.WriteLine($"What is {addCustomerName}'s email address?");
                            string addCustomerEmail = Console.ReadLine();
                            Console.WriteLine($"What is {addCustomerName}'s phone number?");
                            string addCustomerPhone = Console.ReadLine();
                            Console.WriteLine($"{addCustomerName} has been added to our list of customers. \n   Please press enter to continue.");
                            Console.ReadLine();
                        break;
                    case "2":
                        // search for customer
                        AscArt();
                        break;
                    case "3":
                        // view store front inventory
                        AscArt();
                        break;
                    case "4":
                        // place order
                        AscArt();
                        break;
                    case "5":
                        // view order history
                        AscArt();
                        break;
                    case "6":
                        // replenish inventory
                        AscArt();
                        break;
                    case "7":
                        //exit
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
            /* 
                UI needs
            - Add Customer (loop questions in case proper validation is not met to reattempt)
                - ask name
                - ask address
                - ask email
                - ask phone number
            - Search for customer
                - input requires name and address to find customer in db.
            - View storefront inventory
                - 
            */

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
