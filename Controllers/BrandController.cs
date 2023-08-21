using Microsoft.AspNetCore.Mvc;
using WebStoreMadz.Models;

namespace WebStoreMadz.Controllers
{
    public class BrandController : Controller
    {
        private readonly ShopDbContext db;

        public BrandController(ShopDbContext db)
        {
            this.db = db;
        }
     
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBrand(Brand model)
        {
            var brand = new Brand()
            {
                BName = model.BName
            };
            db.Brands.Add(brand);
            db.SaveChanges();
            return RedirectToAction("AddBrand");

        }
        public IActionResult ViewBrand()
        {
            var getAllBrands = db.Brands.ToList();

            return View(getAllBrands);
        }
    }
}
