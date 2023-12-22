using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dumas()
        {
            return View();
        }
    }
}
