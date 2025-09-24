using Microsoft.EntityFrameworkCore;

namespace StockApi.Models
{
    public class ApplicationDbContext  : DbContext
    {
        // Constructor that accepts DbContextOptions and passes it to the base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define DbSet properties for your entities
        public DbSet<Stock> Stocks { get; set; } // Represents the Stocks table
        //public DbSet<User> Users { get; set; }    // Represents the Users table
    }
}
