using Microsoft.AspNetCore.Mvc;

namespace ASPTask.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
