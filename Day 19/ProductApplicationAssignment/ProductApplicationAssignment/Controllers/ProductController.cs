using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductApplicationAssignment.Models;
using ProductApplicationAssignment.Services;

namespace ProductApplicationAssignment.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepo<int, Product> _repo;
        public ProductController(IRepo<int,Product>repo)
        {
            _repo = repo;
           
        }

        //Select Item List
        IEnumerable<SelectListItem> GetCategories()
        {
            List<SelectListItem> categories = new List<SelectListItem>();
            categories.Add(new SelectListItem { Text = "Food", Value = "Food" });
            categories.Add(new SelectListItem { Text = "Toy", Value = "Toy" });
            categories.Add(new SelectListItem { Text = "Clothing", Value = "Clothing" });
            return categories;
        }

        //View 
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IActionResult Details(int id)
        {
            Product product = _repo.Get(id);
            return View(product);
        }

        //Edit
        public IActionResult Edit(int id)
        {
            Product product = _repo.Get(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            _repo.Update(product);
            return RedirectToAction("Index");
        }
        
        //Create
        public IActionResult Create()
        {
            ViewBag.Categories = GetCategories();
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(product);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }

        //Delete
        public IActionResult Delete(int id)
        {
            Product product = _repo.Get(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(int id, Product product)
        {
            _repo.Remove(id);
            return RedirectToAction("Index");
        }

        //Buy
        public IActionResult Buy(int id)
        {

            Product product = _repo.Get(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Buy(int id, Product product)
        {
            _repo.Update(product);


            return RedirectToAction("Index");
        }
    }
}
