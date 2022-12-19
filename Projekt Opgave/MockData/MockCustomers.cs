using Projekt_Opgave.Models;

namespace Projekt_Opgave.MockData
{
    public class MockCustomers
    {
        private static List<Customer> customers = new List<Customer>() {
        new Customer(10, "Jens", "Addresse","222222","email@gmail.com"),
        new Customer(20, "Peter", "Addresse","222222","email@gmail.com"),
        new Customer(30, "Hans", "Addresse","222222","email@gmail.com")
       };
        public static List<Customer> GetMockCustomers() { return customers; }
    }
}
