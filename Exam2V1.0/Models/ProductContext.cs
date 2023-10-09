using Microsoft.EntityFrameworkCore;

namespace Exam2V1._0.Models
{
    public class ProductContext : DbContext //extends DbContext from EFC
    {

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        { }

       public DbSet<Product> Product { get; set; } //creating product
    }
}
