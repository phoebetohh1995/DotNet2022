using ProductApplication.Models;

namespace ProductApplication.Services
{
    public class ProductRepo : IRepo<int, Product>
    {
        static List<Product> Products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Orange",
                Price = 3.00,
                SupplierId = 1,
                Quantity = 50,
                Remarks = "Fresh"
            },
            new Product()
            {
                Id = 2,
                Name = "Apple",
                Price = 2.00,
                SupplierId = 1,
                Quantity = 25,
                Remarks = "Juicy"
            }

        };
        public bool Create(Product t)
        {
            Products.Create(t);
            return true;
        }

        public bool Delete(int k)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int k, Product t)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetT(int k)
        {
            throw new NotImplementedException();
        }
    }
}