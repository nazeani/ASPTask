﻿using Microsoft.AspNetCore.Mvc;

namespace ASPTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
