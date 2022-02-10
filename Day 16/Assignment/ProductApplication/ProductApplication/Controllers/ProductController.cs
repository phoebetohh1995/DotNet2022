using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProductApplication.Models;

namespace ProductApplication.Controllers
{
    public class ProductController : Controller
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

        public IActionResult Index()
        {
            var products = Products;
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            Products.Add(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var productEdit = Products.Where(x => x.Id == id).SingleOrDefault();
            return View(productEdit);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {

            Product productEdit = Products.Single(x => x.Id == product.Id);
            productEdit.Name = product.Name;
            productEdit.Price = product.Price;
            productEdit.SupplierId = product.SupplierId;
            productEdit.Quantity = product.Quantity;
            productEdit.Remarks = product.Remarks;
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var product = Products.Where(x => x.Id == id).SingleOrDefault();
            return View(product);

        }


    }
}