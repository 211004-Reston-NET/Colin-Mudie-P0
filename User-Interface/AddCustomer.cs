using System;
using System.Text.RegularExpressions;

namespace User_Interface
{
    public class AddCustomer : ICustomer
    {
        public string Address(string customerName)
        {   
            Boolean correctFormat = true;
            string input = "";
            while (correctFormat){
                Console.WriteLine($"   What is {customerName}'s address?");
                input = Console.ReadLine().Trim();
                if (Regex.Match(input, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success){
                    correctFormat = false;
                }
                
            }
            return input;
        }

        public string Email(string customerName)
        {
            Boolean correctFormat = true;
            string input = "";
            while (correctFormat){
                Console.WriteLine($"   What is {customerName}'s email address?");
                input = Console.ReadLine().Trim();
                if (Regex.Match(input, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success){
                    correctFormat = false;
                }
            }
            return input;
        }
        public string Name()
        {   
            Boolean correctFormat = true;
            string input ="";
            while (correctFormat)
            {
                input = Console.ReadLine().Trim();
                if (Regex.Match(input, @"^[a-zA-Z]+$").Success)
                {
                    correctFormat = false;
                } else {
                    Console.WriteLine("   Please enter a name for the customer without any numbers or special characters.");
                }
            }
            return input;
        }

        public string Phone(string customerName)
        {   
            Boolean correctFormat = true;
            string input = "";
            while (correctFormat){
                Console.WriteLine($"   What is {customerName}'s phone number?");
                input = Console.ReadLine().Trim();
                if (Regex.Match(input, @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$").Success){
                    correctFormat = false;
                }
            }
            return input;
        }
    }
}