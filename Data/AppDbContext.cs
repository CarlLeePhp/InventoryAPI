using Inventory.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
