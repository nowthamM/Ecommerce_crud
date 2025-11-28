using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Db
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }
        public DbSet<Sales> sales { get; set; }
    }
}
