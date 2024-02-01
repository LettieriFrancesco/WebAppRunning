using Microsoft.AspNetCore.Mvc;

namespace WebAppRunning.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
