using System.ComponentModel.DataAnnotations;

namespace KantriWebApp.Models
{
    public class HuntFishProduct
    {
        public int Id_HuntFishProduct { get; set; }
        [Key]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
