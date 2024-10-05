using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
