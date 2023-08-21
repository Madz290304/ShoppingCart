using Microsoft.AspNetCore.Mvc;
using WebStoreMadz.Models;

namespace WebStoreMadz.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ShopDbContext db;

        public CategoryController(ShopDbContext db) {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCategory() 
        {
        return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category model)
        {
            var ctgry = new Category()
            {
                CName = model.CName
            };
            db.Category.Add(ctgry);
            db.SaveChanges();
            return RedirectToAction("AddCategory");
         
        }
        public IActionResult ViewCategory()
        {
            var getAllCtgry = db.Category.ToList();

            return View(getAllCtgry);
        }
        }
    }

