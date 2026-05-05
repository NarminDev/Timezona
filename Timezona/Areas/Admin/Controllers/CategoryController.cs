using Microsoft.AspNetCore.Mvc;
using Timezona.DAL;
using Timezona.Models;

namespace Timezona.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {


        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Categories.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category product)
        {
            _context.Categories.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
