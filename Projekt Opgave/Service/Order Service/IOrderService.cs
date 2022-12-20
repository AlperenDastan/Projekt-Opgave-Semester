using Projekt_Opgave.Models;

namespace Projekt_Opgave.Service.Order_Service
{
    public interface IOrderService 
    {
        List<OrderModel> GetItems();
        void AddItem(OrderModel item);
        void UpdateItem(OrderModel item);
        OrderModel GetItem(int id);
        public OrderModel DeleteOrder(int id);
        IEnumerable<OrderModel> NameSearch(string str);
        IEnumerable<OrderModel> PriceFilter(int maxPrice, int minPrice = 0);

    }
}
