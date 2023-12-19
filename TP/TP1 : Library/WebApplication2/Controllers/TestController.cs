using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Coucou()
        {
            return View();
        }
    }
}
