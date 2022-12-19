using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Item_Service;

namespace Projekt_Opgave.Pages.Item
{
    public class GetAllItemsModel : PageModel
    {
        private ItemService _itemService;

        public GetAllItemsModel(ItemService itemService)
        {
            _itemService = itemService;
        }

        public List<Models.Item> Items { get; private set; }

        [BindProperty]
        public string SearchString { get; set; }

        [BindProperty]
        public string Type { get; set; }

        [BindProperty]
        public int MinPrice { get; set; }

        [BindProperty]
        public int MaxPrice { get; set; }


        public void OnGet()
        {
            Items = _itemService.GetItems();
        }

        public IActionResult OnPostNameSearch()
        {
            Items = _itemService.NameSearch(SearchString).ToList();
            return Page();
        }

        public IActionResult OnPostPriceFilter()
        {
            Items = _itemService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }
    }
}
