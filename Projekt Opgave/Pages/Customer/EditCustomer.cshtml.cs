using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Customer_Service;

namespace Projekt_Opgave.Pages.Customer
{
    public class EditCustomerModel : PageModel
    {
        private CustomerService _customerService;

        public EditCustomerModel(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [BindProperty]
        public Models.Customer Customer { get; set; }

        public IActionResult OnGet(int id)
        {
            Customer = _customerService.GetCustomer(id);
            if (Customer == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _customerService.UpdateCustomer(Customer);
            return RedirectToPage("GetAllCustomers");
        }
    }
}
