namespace User_Interface
{
    public interface ICustomer
    {
        /// <summary>
        /// This message will tell the user which Menu 
        /// item they selected to be routed here
        /// </summary>
        void Greeting();

        /// <summary>
        /// will return the name of the customer that is asked in the greeting method. use regex to not allow it to contain numbers.
        /// </summary>
        /// <returns> the name of the user will be returned so that we can reference it in our other questions. </returns>
        string Name();

        /// <summary>
        /// Will ask the user for their address. Needs a form of validation from regex to only allow an address to be entered. 
        /// </summary>
        /// <param name="customerName"> Takes in a string that is the Customer's name in order to use it when asking for the address</param>
        /// <returns> Returns the address that is gathered from the Console.ReadLine() </returns>
        string Address(string customerName);

        /// <summary>
        /// Will ask the user for their email. Needs a form of validation from regex to only allow an email address to be entered. 
        /// </summary>
        /// <param name="customerName"> Takes in a string that is the Customer's name in order to use it when asking for the email</param>
        /// <returns> Returns the email that is gathered from the Console.ReadLine() </returns>
        string Email(string customerName);

        /// <summary>
        /// Will ask the user for their phone number. Needs a form of validation from regex to only allow a phone number to be entered. 
        /// </summary>
        /// <param name="customerName"> Takes in a string that is the Customer's name in order to use it when asking for the phone number</param>
        /// <returns> Returns the phone number that is gathered from the Console.ReadLine() </returns>
        string Phone(string customerName);
    }
}