using Projekt_Opgave.Models;

namespace Projekt_Opgave.Service.Order_Service
{
    public class OrderService : IOrderService
    {
        public List<Order> shoppingCart = new List<Order>();

<<<<<<< HEAD

        public void AddToCart(Order item)
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

        public void RemoveFromCart(Order item)
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
        }

=======
>>>>>>> parent of 6ddbd05 (Title test)
    }
}