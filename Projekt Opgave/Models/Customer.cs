using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projekt_Opgave.Models
{
    public class Customer
    {
        [Display(Name = "Customer ID")]
        [Required(ErrorMessage = "Der skal angives et ID til Item")]
        [Range(typeof(int), "0", "10000", ErrorMessage = "ID skal være mellem (1) og (2)")]
        public int Id { get; set; }
       
        [Display(Name = "Customer Navn")]
        [Required(ErrorMessage = "Item skal have et navn")]
        public string Name { get; set; }

        [Display(Name = "Customer Addresse")]
        [Required(ErrorMessage = "Customer skal have en addresse")]
        public string Address { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Der skal angives et telefonnummer")]
        public string Phonenumber { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Der skal angives en email addresse")]
        public string Email { get; set; }
        public Customer(int id, string name, string address, string phonenumber, string email)
        {
            Id = id;
            Name = name;
            Address= address;
            Phonenumber = phonenumber;
            Email = email;
        }
        public Customer()
        {

        }
    }
}
