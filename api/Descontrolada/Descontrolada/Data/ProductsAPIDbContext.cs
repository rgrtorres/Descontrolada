using Descontrolada.Models;
using Microsoft.EntityFrameworkCore;

namespace Descontrolada.Data
{
    public class ProductsAPIDbContext: DbContext
    {
        public ProductsAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
