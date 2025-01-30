using Microsoft.EntityFrameworkCore;
namespace DBFirstProje.Web.Models

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //tablolar
        public DbSet<Product> Products { get; set; } //Products isimli tablo
        public DbSet<Category> Categories { get; set; } // Categories isimli tablo
    }
}
