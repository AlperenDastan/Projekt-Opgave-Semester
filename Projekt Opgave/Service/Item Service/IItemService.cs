using Microsoft.AspNetCore.Mvc;
using Projekt_Opgave.MockData;
using Projekt_Opgave.Models;

namespace Projekt_Opgave.Service.Item_Service
{
    public interface IItemService
    {
        List<Item> GetItems();
        void AddItem(Item item);
        void UpdateItem(Item item);
        Item GetItem(int id);
        public Item DeleteItem(int id);
        IEnumerable<Item> NameSearch(string str);
        IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);
    }
}

