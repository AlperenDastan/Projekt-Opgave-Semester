using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projekt_Opgave.Models
{
    public class OrderModel
    {
        [Range(typeof(int), "0", "10000", ErrorMessage = "ID skal være mellem (1) og (2)")]
        [Display(Name = "Id")]
        [Required(ErrorMessage = "Der skal angives et id")]
        public int Id { get; set; }

        [Display(Name = "Item")]
        [Required(ErrorMessage = "Der skal angives et navn")]
        public string CustomerName { get; set; }
        [Display(Name = "CustomerName")]
        [Required(ErrorMessage = "Der skal angives et navn")]
        public string CustomerEmail { get; set; }
        [Display(Name = "CustomerEmail")]
        [Required(ErrorMessage = "Der skal angives en email")]
        public string CustomerPhoneNumber { get; set; }
        [Display(Name = "CustomerPhoneNumber")]
        [Required(ErrorMessage = "Der skal angives et Telefonnummer")]
        public string Item { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Der skal angives en m;nge")]
        public int Amount { get; set; }

        [Display(Name = "TotalPrice")]
        [Required(ErrorMessage = "Der skal angives en pris")]
        public double TotalPrice { get; set; }

        [Display(Name = "OrderDate")]
        [Required(ErrorMessage = "Der skal angives en dato")]
        public string OrderDate { get; set; }

        [Display(Name = "DeliveryDate")]
        [Required(ErrorMessage = "Der skal angives en dato")]
        public string DeliveryDate { get; set; }


        public OrderModel(int id, string item, int amount, double totalPrice, string orderdate, string deliverydate)
        {
            Id = id;
            Item = item;
            Amount = amount;
            TotalPrice = totalPrice;
            OrderDate = orderdate;
            DeliveryDate = deliverydate;
        }

        public OrderModel()
        {

        }

    }
}
