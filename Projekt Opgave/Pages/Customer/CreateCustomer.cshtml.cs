using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Customer_Service;

namespace Projekt_Opgave.Pages.Customer
{
    public class CreateCustomerModel : PageModel
    {
        private CustomerService _customerService;

        public CreateCustomerModel(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [BindProperty]
        public Models.Customer Customer { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _customerService.AddCustomer(Customer);
            return RedirectToPage("GetAllCustomers");
        }
    }
}
