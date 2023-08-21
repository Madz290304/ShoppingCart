using Microsoft.EntityFrameworkCore;

namespace WebStoreMadz.Models
{
    public class ShopDbContext:DbContext
    {
       public ShopDbContext(DbContextOptions<ShopDbContext>options):base(options)
        {}
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set;}
    }
}
