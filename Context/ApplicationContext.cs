using Microsoft.EntityFrameworkCore;

namespace KantriWebApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AllProduct> AllProducts { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }
        public DbSet<NewProduct> NewProducts { get; set; }
        public DbSet<SpecifiedProduct> SpecifiedProducts { get; set; }
        public DbSet<HuntFishProduct> HuntFishProducts { get; set; }
        public DbSet<AuthModel> Auth { get; set; }
        

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
