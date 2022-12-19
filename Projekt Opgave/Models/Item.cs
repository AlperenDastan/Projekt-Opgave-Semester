using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projekt_Opgave.Models
{
    public class Item
    {
        [Display(Name = "Item ID")]
        [Required(ErrorMessage = "Der skal angives et ID til Item")]
        [Range(typeof(int), "0", "10000", ErrorMessage = "ID skal være mellem (1) og (2)")]
        public int Id { get; set; }

        [Display(Name = "Item Navn")]
        [Required(ErrorMessage = "Item skal have et navn")]
        public string Name { get; set; }

        [Display(Name = "Pris")]
        [Required(ErrorMessage = "Der skal angives en pris")]
        public double Price { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Der skal angives en Description")]

        public string Description { get; set; }

        [Display(Name = "Tag")]
        [Required(ErrorMessage = "Der skal angives et Tag")]
        public string Tag { get; set; }



        public Item()
        {

        }

        public Item(int id, string name, double price, string description, string tag)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Tag = tag;
           
        }

       
    }
}
