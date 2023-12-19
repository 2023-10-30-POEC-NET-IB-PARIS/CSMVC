using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }
        public IActionResult Lotr()
        {
            return View();
        }
    }
}
