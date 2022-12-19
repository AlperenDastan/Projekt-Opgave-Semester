namespace Projekt_Opgave.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }

        public string Item { get; set; }

        public int Amount { get; set; }

        public double TotalPrice { get; set; }

        public string OrderDate { get; set; }

        public string DeliveryDate { get; set; }


        public OrderModel(int id, string item, int amount, double totalPrice, string orderdate, string deliverydate)
        {
            OrderId = id;
            Item = item;
            Amount = amount;
            TotalPrice = totalPrice;
            OrderDate = orderdate;
            DeliveryDate = deliverydate;
        }

    }
}
