using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Db
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Products> products { get; set; }
    }
}
