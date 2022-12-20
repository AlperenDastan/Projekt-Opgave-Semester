using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Item_Service;
using Projekt_Opgave.Service.Order_Service;

namespace Projekt_Opgave.Pages.Orders
{
    public class EditOrderModel : PageModel
    {
        private OrderService _orderService;

        public EditOrderModel(OrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Models.OrderModel Item { get; set; }

        public IActionResult OnGet(int id)
        {
            Item = _orderService.GetItem(id);
            if (Item == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _orderService.UpdateItem(Item);
            return RedirectToPage("Order");
        }
    }
   
}