using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Item_Service;
using Projekt_Opgave.Service.Order_Service;

namespace Projekt_Opgave.Pages.Orders
{
    public class DeleteOrderModel : PageModel
    {
        private OrderService _orderService;

        [BindProperty]
        public Models.OrderModel Order { get; set; }
        //public int DeletedItemId { get; set; }
        public DeleteOrderModel(OrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult OnGet(int id)
        {
            Order = _orderService.GetItem(id);
            if (Order == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            Models.OrderModel deletedOrder = _orderService.DeleteOrder(Order.Id);
            if (deletedOrder == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return RedirectToPage("Order");
        }
    }
}
