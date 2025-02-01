using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
