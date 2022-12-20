using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Models;
using Projekt_Opgave.Service.Item_Service;
using Projekt_Opgave.Service.Order_Service;

namespace Projekt_Opgave.Pages.Orders
{
    public class OrderModel : PageModel
    {
		private OrderService _orderService;

		public OrderModel(OrderService itemService)
		{
			_orderService = itemService;
		}

        [BindProperty]
        public string Type { get; set; }

        [BindProperty]
        public int MinPrice { get; set; }

        [BindProperty]
        public int MaxPrice { get; set; }

        [BindProperty]
        public string SearchString { get; set; }
        [BindProperty]
		public List<Models.OrderModel> Order { get; set; }

		public IActionResult OnGet()
		{
			Order = _orderService.GetItems();
			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			//_orderService.AddItem(Order);
			return RedirectToPage("GetAllItems");
		}
        public IActionResult OnPostNameSearch()
        {
            Order = _orderService.NameSearch(SearchString).ToList();
            return Page();
        }

        public IActionResult OnPostPriceFilter()
        {
            Order = _orderService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }
    }
}
