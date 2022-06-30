using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
