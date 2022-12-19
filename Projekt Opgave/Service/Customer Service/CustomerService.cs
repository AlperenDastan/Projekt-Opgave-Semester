using Projekt_Opgave.MockData;
using Projekt_Opgave.Models;
using Projekt_Opgave.Service.Customer_Service;

namespace Projekt_Opgave.Service.Customer_Service
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> _customers;

        private JsonFileCustomerService JsonFileCustomerService { get; set; }

        public CustomerService(JsonFileCustomerService jsonFileCustomerService)
        {
            JsonFileCustomerService = jsonFileCustomerService;
            // _items = MockItems.GetMockItems();
            _customers = JsonFileCustomerService.GetJsonCustomers().ToList();
        }

        public CustomerService()
        {
            _customers = MockCustomers.GetMockCustomers();
        }

        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in _customers)
            {
                if (customer.Id == id)
                    return customer;
            }

            return null;
        }
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
            JsonFileCustomerService.SaveJsonCustomers(_customers);
        }


        public void UpdateCustomer(Customer customer)
        {
            if (customer != null)
            {
                foreach (Customer i in _customers)
                {
                    if (i.Id == customer.Id)
                    {
                        i.Name = customer.Name;
                        i.Address = customer.Address;
                        i.Phonenumber = customer.Phonenumber;
                        i.Email = customer.Email;
                    }
                }
                JsonFileCustomerService.SaveJsonCustomers(_customers);
            }
        }

        public Customer DeleteCustomer(int customerId)
        {
            Customer customerToBeDeleted = null;
            foreach (Customer customer in _customers)
            {
                if (customer.Id == customerId)
                {
                    customerToBeDeleted = customer;
                    break;
                }
            }

            if (customerToBeDeleted != null)
            {
                _customers.Remove(customerToBeDeleted);
                JsonFileCustomerService.SaveJsonCustomers(_customers);
            }

            return customerToBeDeleted;
        }

        public List<Customer> GetCustomers() { return _customers; }

        public IEnumerable<Customer> NameSearch(string str)
        {
            List<Customer> nameSearch = new List<Customer>();
            foreach (Customer customer in _customers)
            {
                if (string.IsNullOrEmpty(str) || customer.Name.ToLower().Contains(str.ToLower()) || customer.Phonenumber.ToLower().Contains(str.ToLower()) || customer.Email.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(customer);
                }
            }

            return nameSearch;
        }

    }
    }


