
using Models;

namespace User_Interface
{
    public class SingletonCustomer
    {
        public static Customer customer = new Customer();
        public static Orders orders = new Orders();
        public static string location { get; set; }
    }
}
