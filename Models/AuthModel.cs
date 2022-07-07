using System.ComponentModel.DataAnnotations;

namespace KantriWebApp.Models
{
    public class AuthModel
    {
        public int Id_user { get; set; }
        [Key]
        public string login { get; set; }
        public decimal Password { get; set; }
    }
}
