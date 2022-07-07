using System.ComponentModel.DataAnnotations;

namespace KantriWebApp.Models
{
    public class BasketProduct
    {
        public int Id_BasketProduct { get; set; }
        [Key]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
