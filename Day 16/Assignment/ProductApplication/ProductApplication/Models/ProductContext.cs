using Microsoft.EntityFrameworkCore;

namespace ProductApplication.Models
{
    public class ProductContext :DbContext
    {
        public DbSet<Product> Products { get; set;}
    }
}
