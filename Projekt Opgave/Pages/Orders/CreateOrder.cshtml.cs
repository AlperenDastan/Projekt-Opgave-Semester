using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Item_Service;
using Projekt_Opgave.Service.Order_Service;

namespace Projekt_Opgave.Pages.Orders
{
    public class CreateOrderModel : PageModel
    {
        private OrderService _orderService;

        public CreateOrderModel(OrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Models.OrderModel order { get; set; }

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
            _orderService.AddItem(order);
            return RedirectToPage("Order");
        }
    }
}
