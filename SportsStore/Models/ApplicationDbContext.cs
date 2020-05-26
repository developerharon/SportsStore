using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    /// <summary>
    /// it's the bridge between the application and EF Core and provides access to the application's data using model objects, will be used to read and write applications data
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        /// <summary>
        /// Provides acceess to the Product objects in the database
        /// </summary>
        public DbSet<Product> Products { get; set; }
    }
}
