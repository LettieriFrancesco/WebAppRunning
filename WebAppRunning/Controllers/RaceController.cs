﻿using Microsoft.AspNetCore.Mvc;

namespace WebAppRunning.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
