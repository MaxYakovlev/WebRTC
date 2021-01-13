using Microsoft.AspNetCore.Mvc;

namespace WebRTC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
