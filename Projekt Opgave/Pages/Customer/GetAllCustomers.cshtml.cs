using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Customer_Service;

namespace Projekt_Opgave.Pages.Customer
{
    public class GetAllCustomersModel : PageModel
    {
        private CustomerService _customerService;

        public GetAllCustomersModel(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public List<Models.Customer> Customers { get; private set; }

        [BindProperty]
        public string SearchString { get; set; }

        public void OnGet()
        {
            Customers = _customerService.GetCustomers();
        }

        public IActionResult OnPostNameSearch()
        {
            Customers = _customerService.NameSearch(SearchString).ToList();
            return Page();
        }
    }
}
