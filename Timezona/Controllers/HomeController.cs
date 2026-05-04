using Microsoft.AspNetCore.Mvc;

namespace Timezona.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
