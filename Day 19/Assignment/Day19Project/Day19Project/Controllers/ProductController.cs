using Day19Project.Models;
using Day19Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day19Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepo<int, Product> _repo;

        public ProductController(IRepo<int, Product> repo)
        {
            _repo = repo;
        }

        IEnumerable<SelectListItem> GetCategories()
        {
            List<SelectListItem> categories = new List<SelectListItem>();
            categories.Add(new SelectListItem { Text = "Food", Value = "Food" });
            categories.Add(new SelectListItem { Text = "Toy", Value = "Toy" });
            categories.Add(new SelectListItem { Text = "Clothing", Value = "Clothing" });
            return categories;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult Details(int id)
        {
            Product product = _repo.Get(id);
            return View(product);
        }

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


        
    }
}
