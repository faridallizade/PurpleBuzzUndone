using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Models;

namespace PurpleBuzz.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Card> Cards { get; set; }  
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
