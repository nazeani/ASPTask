using Microsoft.AspNetCore.Mvc;

namespace ASPTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
