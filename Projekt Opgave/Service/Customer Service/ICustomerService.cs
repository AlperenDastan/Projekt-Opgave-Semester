using Projekt_Opgave.Models;

namespace Projekt_Opgave.Service.Customer_Service
{
    public interface ICustomerService
    {

        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomer(int id);
        public Customer DeleteCustomer(int id);
        IEnumerable<Customer> NameSearch(string str);
    }
}
