using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Item_Service;
using System.Reflection;

namespace Projekt_Opgave.Pages
{
    public class CreateItemModel : PageModel
    {
        private ItemService _itemService;

        public CreateItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }

        [BindProperty]
        public Models.Item Item { get; set; }

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
            _itemService.AddItem(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
