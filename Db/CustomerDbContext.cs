using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Db
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        { }
        public DbSet<Customer> customers { get; set; }
    }
}
