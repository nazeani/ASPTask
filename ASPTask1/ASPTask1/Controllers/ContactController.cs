using Microsoft.AspNetCore.Mvc;

namespace ASPTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
