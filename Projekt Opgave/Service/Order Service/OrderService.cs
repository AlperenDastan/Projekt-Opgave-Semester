using Projekt_Opgave.MockData;
using Projekt_Opgave.Models;
using Projekt_Opgave.Service.Item_Service;

namespace Projekt_Opgave.Service.Order_Service
{
    public class OrderService : IOrderService
    {
		/*public List<OrderModel> shoppingCart = new List<OrderModel>();

        public void AddToCart(OrderModel item)
        {
            var existingItem = shoppingCart.FirstOrDefault(i => i.OrderId == item.OrderId);
            if (existingItem != null)
            {
                existingItem.Amount += item.Amount;
            }
            else
            {
                shoppingCart.Add(item);
            }
        }

        public void RemoveFromCart(OrderModel item)
        {
            var existingItem = shoppingCart.FirstOrDefault(i => i.OrderId == item.OrderId);
            if (existingItem != null)
            {
                existingItem.Amount -= item.Amount;
                if (existingItem.Amount <= 0)
                {
                    shoppingCart.Remove(existingItem);
                }
            }
        }*/


		private List<OrderModel> _items;

		private JsonFileServiceOrder JsonFileItemService { get; set; }

		public OrderService(JsonFileServiceOrder jsonFileItemService)
		{
			JsonFileItemService = jsonFileItemService;
			// _items = MockItems.GetMockItems();
			_items = JsonFileItemService.GetJsonItems().ToList();
		}

		/*public ItemService()
		{
			_items = MockItems.GetMockOr();
		}*/

		public OrderModel GetItem(int id)
		{
			foreach (OrderModel item in _items)
			{
				if (item.Id == id)
					return item;
			}

			return null;
		}
		public void AddItem(OrderModel item)
		{
			_items.Add(item);
			JsonFileItemService.SaveJsonItems(_items);
		}


        public void UpdateItem(OrderModel item)
		{
			if (item != null)
			{
				foreach (OrderModel i in _items)
				{
					if (i.Id == item.Id)
					{
						i.Item = item.Item;
						i.Amount = item.Amount;
                        i.TotalPrice = item.TotalPrice;
                        i.CustomerEmail = item.CustomerEmail;
                        i.CustomerPhoneNumber = item.CustomerPhoneNumber;
                        i.CustomerName = item.CustomerName;
                        i.DeliveryDate = item.DeliveryDate;
                        i.OrderDate = item.OrderDate;
                    }
				}
				JsonFileItemService.SaveJsonItems(_items);
			}
		}

		public OrderModel DeleteOrder(int orderId)
		{
			OrderModel itemToBeDeleted = null;
			foreach (OrderModel order in _items)
			{
				if (order.Id == orderId)
				{
					itemToBeDeleted = order;
					break;
				}
			}

			if (itemToBeDeleted != null)
			{
				_items.Remove(itemToBeDeleted);
				JsonFileItemService.SaveJsonItems(_items);
			}

			return itemToBeDeleted;
		}

		public List<OrderModel> GetItems() { return _items; }

		public IEnumerable<OrderModel> NameSearch(string str)
		{
			List<OrderModel> nameSearch = new List<OrderModel>();
			foreach (OrderModel order in _items)
			{
				if (string.IsNullOrEmpty(str) || order.Id.ToString().Equals(str.ToLower()))
				{
					nameSearch.Add(order);
				}
			}

			return nameSearch;
		}
		//public IEnumerable<OrderModel> NameSearch(string str, string type) // Dette er en Overload. Man kan kopiere samme metode, men de skal have andre parametre, enten flere eller mindre. 
		//{
		//	List<OrderModel> nameSearch = new List<OrderModel>();
		//	foreach (OrderModel item in _items)
		//	{
		//		if (string.IsNullOrEmpty(str) || item.Item.ToLower().Contains(str.ToLower()))
		//		{
		//			nameSearch.Add(item);
		//		}
		//	}

		//	return nameSearch;
		//}

		public IEnumerable<OrderModel> PriceFilter(int maxPrice, int minPrice = 0)
		{
			List<OrderModel> filterList = new List<OrderModel>();
			foreach (OrderModel item in _items)
			{
				if ((minPrice == 0 && item.Amount <= maxPrice) || (maxPrice == 0 && item.Amount >= minPrice) || (item.Amount >= minPrice && item.Amount <= maxPrice))
				{
					filterList.Add(item);
				}
			}

			return filterList;
		}


	}
}